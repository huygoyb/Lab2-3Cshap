using System;

namespace Lab3_Part2
{
    public class ListBox : Window
    {
        public ListBox(int top, int left, string contents)
        :  base(top, left)
        {
            listBoxContents = contents;
        }
        // an overridden version (note keyword) because in the
        // derived method we change the behavior
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Writing string to the listbox:{0}", listBoxContents);
        }
        private string listBoxContents;// new member variable
    }
}