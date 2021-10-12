using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// C Sharp 1 Assessment 2
// Ellena Begg, Team Elljam, Sprint Number Two
// Date: 12/10/2021
// Version 2.0 (All functions implemented and working, 
// No: error trapping included, useful user feedback messages, relevant comments)

// Astronomical Processing
//
// Explanation: A program for a local observatory that stores the number of neutrino
// interactions per hour as integer values in an array of size 24. This forms-based 
// GUI application displays the data in a list box and uses text boxes and buttons for processing.
//
// Functionality: User can add/remove/edit data using a textbox for input. Data can be
// sorted or searched. An option to randomly generate data with a button press is included


namespace AstronomicalProcessing
{
    public partial class AstronomicalProcessingForm : Form
    {
        public AstronomicalProcessingForm()
        {
            InitializeComponent();
        }
        // •	The array is of type integer.
        // •	The array has 24 elements to reflect the number of hours per day.
        static int max = 24;
        int[] astroArray = new int[max];
        // Points at next empty index of array
        int nextEmpty = 0;
        Random rnd = new Random();

        #region Sprint One
        #region Add/Remove/Edit
        // •	The program must be able to add, edit and delete data values.
        // •	The program must generate an error message if the text box is empty.

        // Enables user to add an item to the array using the Textbox
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Checks to make sure user has entered a number in Text Box
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                // Checks to make sure list isn't already full
                if (nextEmpty < 24)
                {
                    Int32.TryParse(TextBoxInput.Text, out int temp);
                    astroArray[nextEmpty] = temp;
                    nextEmpty++;
                    StripStatus.Text = "Data has been added";
                }
                else
                {
                    // If there are already 24 items in the array
                    StripStatus.Text = "ERROR: Cannot add, list is already full";
                }
                DisplayArray();
                TextBoxInput.Clear();
            }
            else
            {
                // If no number entered in Text Box
                StripStatus.Text = "ERROR: Enter a number in the Text Box";
            }

        }

        // Enables user to remove a selected item from the listbox
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            // Checks to make sure user has selected an item in the Listbox
            if (ListBoxOutput.SelectedIndex != -1)
            {
                // Code for Yes/No confirmation message
                DialogResult delRecord = MessageBox.Show("Do you want to delete this record?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (delRecord == DialogResult.Yes)
                {
                    // If user confirms deletion
                    int selected = ListBoxOutput.SelectedIndex;
                    astroArray[selected] = astroArray[nextEmpty - 1];
                    StripStatus.Text = "Data has been deleted";
                    nextEmpty--;
                    DisplayArray();
                    TextBoxInput.Clear();
                }

                else
                {
                    // If user chooses not to delete
                    StripStatus.Text = "Data was not deleted";
                }
            }
            else
            {
                // If no item selected in Listbox
                StripStatus.Text = "ERROR: Cannot remove, no item selected";
            }
        }

        // Enables user to edit a selected item in the listbox
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Checks to see if user has selected an item in the Listbox
            if (ListBoxOutput.SelectedIndex != -1)
            {
                // Checks to see if user has entered text to edit
                if (!string.IsNullOrEmpty(TextBoxInput.Text))
                {
                    int selected = ListBoxOutput.SelectedIndex;

                    // Code for Yes/No confirmation message
                    DialogResult delRecord = MessageBox.Show("Do you want to edit this record?",
                        "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    Int32.TryParse(TextBoxInput.Text, out int edited);
                    if (delRecord == DialogResult.Yes)
                    {
                        astroArray[selected] = edited;
                        DisplayArray();
                        TextBoxInput.Clear();
                        // Successful edit
                        StripStatus.Text = "Data has been edited";
                    }

                    else
                    {
                        // If user chooses not to edit
                        TextBoxInput.Clear();
                        StripStatus.Text = "Data was not edited";
                    }
                }
                else
                {
                    // If user has selected Listbox item but hasn't entered number for editing
                    StripStatus.Text = "Enter your desired edit in the Text Box";
                }
            }
            else
            {
                // If user clicks button without selecting a Listbox item
                StripStatus.Text = "ERROR: Cannot edit, no item selected";
            }
        }
        #endregion

        #region Sort/Search
        // •	The client must be able to click a button to bubble sort the data.
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            SortArray();
            DisplayArray();
        }

        // •	The sort method must be coded using the Bubble Sort algorithm.
        private void SortArray()
        {
            // Checks that Listbox isn't empty before sorting
            if (nextEmpty > 0)
            {
                for (int i = 0; i < nextEmpty; i++)
                {
                    for (int j = i + 1; j < nextEmpty; j++)
                    {
                        if (astroArray[i] > astroArray[j])
                        {
                            // swap routine
                            int temp = astroArray[i];
                            astroArray[i] = astroArray[j];
                            astroArray[j] = temp;
                        }
                    }
                }
                StripStatus.Text = "Data sorted in ascending order";
            }
            else
            {
                // If the array is empty
                StripStatus.Text = "ERROR: Cannot sort, no data in list";
            }
        }

        // •	The search method must be coded using the Binary Search algorithm.
        // •	The client can use a text box input to search the array.
        // •	The client must be able to enter search data and click a button to activate a binary search.
        // •	The program must generate an error message if the search is not successful.
        // •	The program must generate a message if the search is successful.
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Checks whether list is empty before searching
            if (nextEmpty > 0)
            {
                // Checks if user has entered a search query in the Text Box
                // •	The program must generate an error message if the text box is empty.
                if (!string.IsNullOrEmpty(TextBoxInput.Text))
                {
                    SortArray();
                    DisplayArray();
                    Int32.TryParse(TextBoxInput.Text, out int target);
                    int lowBound = 0;
                    int highBound = max - 1;
                    int mid = 0;
                    bool found = false;

                    // Binary search code
                    while (lowBound <= highBound)
                    {
                        mid = (lowBound + highBound) / 2;
                        if (target == astroArray[mid])
                        {
                            found = true;
                            break;
                        }
                        else if (target > astroArray[mid])
                        {
                            lowBound = mid + 1;
                        }
                        else
                        {
                            highBound = mid - 1;
                        }
                    }

                    if (found)
                    {
                        // Search target found
                        // •	The program must generate a message if the search is successful.
                        TextBoxInput.Clear();
                        ListBoxOutput.SelectedIndex = mid;
                        StripStatus.Text = "Search target \'" + target + "\' found at element " + (mid + 1);
                    }
                    else
                    {
                        // Search target not found
                        // •	The program must generate an error message if the search is not successful.
                        TextBoxInput.Clear();
                        StripStatus.Text = "ERROR: Search target \'" + target + "\' not found";
                    }
                }
                else
                {
                    // If user hasn't entered a search query
                    StripStatus.Text = "ERROR: Enter a search query in the Text Box";
                }
            }
            else
            {
                // If list is empty
                StripStatus.Text = "ERROR: Cannot search, no data in list";
            }

        }
        #endregion

        #region Utilities

        // •	The program must load random data into the array using a button click.
        // •	The array is filled with random integers to simulate the data stream (numbers between 10 and 99).
        private void ButtonFill_Click(object sender, EventArgs e)
        {
            // If list is empty, fill with data
            if (nextEmpty == 0)
            {
                GenerateData();
                DisplayArray();
            }
            // If list contains data, ask for confirmation before overwriting
            else
            {
                // Yes/No confirmation message code before overwriting current data
                DialogResult delRecord = MessageBox.Show("Do you want to generate new data? (Current data will be overwritten)",
                       "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (delRecord == DialogResult.Yes)
                {
                    nextEmpty = 0;
                    GenerateData();
                    DisplayArray();
                }

                else
                {
                    StripStatus.Text = "Data was not overwritten";
                }
                
            }
        }

        // Randomly generates 24 two-digit numbers to fill array
        private void GenerateData()
        {
            for (int x = 0; x < max; x++)
            {
                astroArray[x] = rnd.Next(10, 99);
                nextEmpty++;
                StripStatus.Text = "Array filled with randomly-generated data";
            }

            // Code to ensure no repeated numbers in random generation
            //for (int i = 0; i < max; i++)
            //{
            //    for (int j = i + 1; j < max; j++)
            //    {
            //        if (astroArray[i] == astroArray[j])
            //        {
            //            astroArray[j] = rnd.Next(10, 99);
            //        }
            //    }
            //}
        }

        // •	All data is displayed in a ListBox.
        private void DisplayArray()
        {
            ListBoxOutput.Items.Clear();
            for (int y = 0; y < nextEmpty; y++)
            {
                ListBoxOutput.Items.Add(astroArray[y]);
            }
        }
        
        // Prevents non-integer input from user
        private void TextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
        #endregion

        #endregion

        #region Sprint Two

        private void ButtonSequentialSearch_Click(object sender, EventArgs e)
        {
            int target;
            bool found = false;

            // TODO check text is in the textbox, or selected item in listbox
            if (!string.IsNullOrEmpty(TextBoxInput.Text))
            {
                Int32.TryParse(TextBoxInput.Text, out target);
                for (int i = 0; i < nextEmpty; i++)
                {

                    if (target == astroArray[i])
                    {
                        found = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a number in Text box to Search for");
            }

            // display results
            if (found)
                MessageBox.Show("Found");
            else
                MessageBox.Show("Not Found");
        }

        #region Utilities
        private int FindMinimum()
        {
            // Find minimum number in the array, return the value
            int minimum = 100;

            for (int i = 0; i <= nextEmpty - 1; i++)
            {
                if (astroArray[i] <= minimum)
                    minimum = astroArray[i];
            }

            return minimum;
        }

        private int FindMaximum()
        {
            // Find maximum number in the array, return the value
            int maximum = 0;

            for (int i = 0; i <= nextEmpty - 1; i++)
            {
                if (astroArray[i] >= maximum)
                    maximum = astroArray[i];
            }

            return maximum;
        }
        #endregion

        #region Mathematical Functions
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            // formula:
            // min + max divided by 2 = mid-extreme
            //TODO error trapping, messages, comments
            int minimum = FindMinimum();
            int maximum = FindMaximum();

            double midExtreme = (minimum + maximum) / 2.0;

            TextBoxMidExtreme.Text = midExtreme.ToString("N2");
        }

        private void ButtonMode_Click(object sender, EventArgs e)
        {
            // formula:
            // TO DO
            //TODO error trapping, messages, comments
            int element;
            int frequency = 1;
            int mode = 0;
            int counter;

            for (int i = 0; i < astroArray.Length; i++)
            {
                counter = 0;
                element = astroArray[i]; // set element to first index
                for (int j = 0; j < astroArray.Length; j++)
                {
                    if (element == astroArray[j]) // go through all items to check each element if same
                    {
                        counter++; // if found, increment count                       
                    }
                }
                if (counter >= frequency)
                {
                    // if this number most frequent, set 'number' and 'frequency'
                    // subsequent numbers, as go through indexes, will overwrite earlier ones with same frequency
                    frequency = counter;
                    mode = element;
                }
            }
            TextBoxMode.Text = mode.ToString();
        }

        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            // formula:
            // TO DO
            //TODO error trapping, messages, comments
            // add all items
            double total = 0;
            for (int i = 0; i < nextEmpty; i++)
            {
                //total = total + astroArray[i];
                total += astroArray[i];

            }
            // divide by number of items
            double average = total / (nextEmpty);

            // Display results, to two decimal points
            TextBoxAverage.Text = average.ToString("N2");
        }

        private void ButtonRange_Click(object sender, EventArgs e)
        {
            // formula:
            // TO DO
            //TODO error trapping, messages, comments
            int minimum = FindMinimum();
            int maximum = FindMaximum();

            int range = maximum - minimum;

            // Display results
            TextBoxRange.Text = range.ToString();
        }
        #endregion

        #endregion


    }
}
