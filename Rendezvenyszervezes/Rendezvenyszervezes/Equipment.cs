namespace Rendezvenyszervezes {
    public class Equipment {
        string name;
        int numberOfUses;
        int maintenanceFrequency;
        int size;
        public Equipment(string _name, int _numberOfUses, int _maintenanceFreqeuency, int _size) {
            this.name = _name;
            this.numberOfUses = _numberOfUses;
            this.maintenanceFrequency = _maintenanceFreqeuency;
            this.size = _size;
        }
    }
}