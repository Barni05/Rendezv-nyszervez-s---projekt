namespace Rendezvenyszervezes {
    public class Equipment {
        string name;
        int numberOfUses;
        int maintenanceFrequency;
        int size;
        public Equipment(string _name, int _size) {
            this.name = _name;
            this.numberOfUses = 0;
            this.maintenanceFrequency = 1;
            this.size = _size;
        }
    }
}