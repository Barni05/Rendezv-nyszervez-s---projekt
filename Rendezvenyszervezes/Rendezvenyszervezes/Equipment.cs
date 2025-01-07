namespace Rendezvenyszervezes {
    public class Equipment {
        int id;
        string name;
        int numberOfUses;
        int maintenanceFrequency;
        int size;
        public Equipment(int _id, string _name, int _numberOfUses, int _maintenanceFreqeuency, int _size) {
            this.Id = _id;
            this.Name = _name;
            this.NumberOfUses = _numberOfUses;
            this.MaintenanceFrequency = _maintenanceFreqeuency;
            this.Size = _size;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfUses { get => numberOfUses; set => numberOfUses = value; }
        public int MaintenanceFrequency { get => maintenanceFrequency; set => maintenanceFrequency = value; }
        public int Size { get => size; set => size = value; }
    }
}