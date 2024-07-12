using Group;

class Program
{
    static void Main(string[] args)
    {
        GroupManager manager = new GroupManager();
        manager.AddGroup("Group 1");
        manager.AddGroup("Group 2");
        manager.AddGroup("Group 3");
        manager.AddGroup("Group 1");
        manager.PrintGroups();
    }
}
