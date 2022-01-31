
namespace Counter
{
    public static class FormatListBox
    {      
        public static void ChangeValue(ListBox listbox, TextBox textBox)
        {
            if (listbox.SelectedItems.Count != 0)
            {
                if(textBox.Text != (string)listbox.SelectedItem) //if the values are equal and copied, the listbox hangs the program
                {
                    while (listbox.SelectedIndex != -1)
                    {
                        listbox.Items.Insert(listbox.SelectedIndex, textBox.Text);
                        listbox.Items.Remove(listbox.SelectedItem);                        
                    }
                }
                
                textBox.Text = String.Empty; //clearing the textbox so the next index can be selected    
                listbox.SelectedIndex = -1; //unselect selected index
            }
            
            
        }

        public static void TextBoxtoListIndex(ListBox listbox, TextBox textbox)
        {
            if (listbox.SelectedIndex != -1)
                textbox.Text = listbox.SelectedItem.ToString();
        }

        public static void DeleteIndex(ListBox listbox, TextBox textbox)
        {
            if (listbox.SelectedItems.Count != 0)
            {
                while (listbox.SelectedIndex != -1)
                {
                    listbox.Items.RemoveAt(listbox.SelectedIndex);
                    textbox.Text = String.Empty;
                }
            }
        }
    }
}