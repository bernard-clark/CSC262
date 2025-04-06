using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq; // Used for convenient array operations such as strings
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms; // Provides UI elements such as Form, TextBox, Button, and MessageBox

namespace CSC262
{
    public partial class FormTesting : Form
    {

        public FormTesting()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Creat a timer that will tell us how long the code has been running for
            Stopwatch watch = new Stopwatch();
            // Start the timer
            watch.Start();

            // This will be the size of the array
            int iSize = 10;

            // Create an array
            int[] arrInts = new int[iSize];

            // Enter you number and press enter
            Console.WriteLine("Enter user number:");

            // Create string variable and get user input from the keyboard and store it in the variable
            string userNumber = Console.ReadLine();

            // Print value of the variable (userNumber), which will display the input value
            Console.WriteLine("User number is: " + userNumber);

            {

                // Create a loop so we can see how long it will run
                for (int i = 0; i < iSize; i++)
                {
                    // Add a delay - 100 milliseconds * 10 = 1000 milliseconds = 1 second
                    Thread.Sleep(100);
                }
                // Stop the timer
                watch.Stop();

                // Show the elapsed time in a message box
                MessageBox.Show("The execution time was: " + watch.ElapsedMilliseconds + " ms");
            }            
        }
    }
}