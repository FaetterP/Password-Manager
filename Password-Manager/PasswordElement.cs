namespace Password_Manager
{
    class PasswordElement
    {
        private string _name;
        private string _key;

        public string Name => _name;
        public string Key => _key;

        public PasswordElement(string line)
        {
            string[] arr = line.Split(" ");

            _name = arr[0];
            _key = arr[1];
        }
    }
}
