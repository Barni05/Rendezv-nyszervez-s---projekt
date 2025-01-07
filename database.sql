-- Create database
CREATE DATABASE event_organizer;

-- Use database
USE event_organizer;

-- Create Locations table (now includes event venue properties)
CREATE TABLE Locations (
    location_id INT AUTO_INCREMENT PRIMARY KEY,
    address VARCHAR(255) NOT NULL,
    capacity INT, -- Added for event capacity
    available_times VARCHAR(255), -- Added for event times
    elegance INT, -- Added for venue elegance
    catering_type VARCHAR(255) -- Added for catering type
);

-- Create Warehouse table
CREATE TABLE Warehouse (
    warehouse_id INT AUTO_INCREMENT PRIMARY KEY,
    location_id INT NOT NULL,
    capacity INT NOT NULL,
    FOREIGN KEY (location_id) REFERENCES Locations(location_id)
);

-- Create Equipment table
CREATE TABLE Equipment (
    equipment_id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(255) NOT NULL,
    volume DECIMAL NOT NULL
);

-- Create Warehouse_Equipment table (junction table)
CREATE TABLE Warehouse_Equipment (
    warehouse_id INT NOT NULL,
    equipment_id INT NOT NULL,
    quantity INT NOT NULL DEFAULT 0,
    PRIMARY KEY (warehouse_id, equipment_id),
    FOREIGN KEY (warehouse_id) REFERENCES Warehouse(warehouse_id),
    FOREIGN KEY (equipment_id) REFERENCES Equipment(equipment_id)
);

-- Create TruckParking table
CREATE TABLE TruckParking (
    parking_id INT AUTO_INCREMENT PRIMARY KEY,
    location_id INT NOT NULL,
    truck_count INT NOT NULL,
    FOREIGN KEY (location_id) REFERENCES Locations(location_id)
);

-- Create Truck table
CREATE TABLE Truck (
    truck_id INT AUTO_INCREMENT PRIMARY KEY,
    parking_id INT NOT NULL,
    current_location INT NOT NULL, 
    FOREIGN KEY (parking_id) REFERENCES TruckParking(parking_id),
    FOREIGN KEY (current_location) REFERENCES Locations(location_id)
);

-- Create Event table (now references Locations directly)
CREATE TABLE Event (
    event_id INT AUTO_INCREMENT PRIMARY KEY,
    location_id INT NOT NULL, -- Now references Locations table
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    type VARCHAR(255) NOT NULL, 
    FOREIGN KEY (location_id) REFERENCES Locations(location_id)
);

-- Create Event_Equipment table (junction table)
CREATE TABLE Event_Equipment (
    event_id INT NOT NULL,
    equipment_id INT NOT NULL,
    quantity INT NOT NULL,
    PRIMARY KEY (event_id, equipment_id),
    FOREIGN KEY (event_id) REFERENCES Event(event_id),
    FOREIGN KEY (equipment_id) REFERENCES Equipment(equipment_id)
);