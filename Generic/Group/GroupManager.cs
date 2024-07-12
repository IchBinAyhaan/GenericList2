namespace Group
{
    internal class GroupManager
    {
        private List<Group> groups = new List<Group>();

        public void AddGroup(string groupName)
        {
            if (!groups.Exists(g => g.Name == groupName))
            {
                Group newGroup = new Group(groupName);
                groups.Add(newGroup);
                Console.WriteLine($"Group '{groupName}' added successfully.");
            }
            else
            {
                Console.WriteLine($"Group '{groupName}' already exists.");
            }
        }
        public void PrintGroups()
        {
            Console.WriteLine("Groups:");
            foreach (var group in groups)
            {
                Console.WriteLine(group.Name);
            }
        }
    }
  
}
