using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoIfLoopArrayCS
{
    public partial class frmDemoIfArrayLoop : Form
    {
        public frmDemoIfArrayLoop()
        {
            InitializeComponent();
        }

        #region "if"

        /// <summary>
        /// Enter a number and click Enter. 
        /// It will test If the input is a... 
        ///    1. Number 
        ///    2. Double 
        ///    3. int
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIfDemo_Click(object sender, EventArgs e)
        {

            // variables
            string userInput = string.Empty;  // Holds the user inputa string
            double userInputDouble = 0.0;    // Holds the user input if it converts to a Double
            int userInputint = 0;     // Holds the user input if it converts to a int
            string output = string.Empty;     // Holds the output to be displayed to the user

            // Enter a break point on userInput = tbIfInput.Text and you can 
            // watch the execution of the code from start to finish
            // press...
            //   F10 - step over
            //   F11 - step into (this is when you want to step into functions)
            userInput = tbIfInput.Text;  // Get the input from the text box

            if (int.TryParse(userInput, out userInputint))  // If the input is an int
            {
                // create the message to be output to the user
                output = userInputint.ToString("n0") + " = int";
            }
            else if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                // create the message to be output to the user
                output = userInputDouble.ToString("n2") + " = Double";
            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                output = userInput + " = Not a Number (NaN)";
            }

            // output the message to the user
            lbIfOutput.Text = output;

        }
        #endregion

        #region "nested if"

        /// <summary>
        /// Enter a number and click Enter. 
        /// It will test If the number Is a... 
        ///    1. Number 
        ///    2. Double 
        ///    3. int
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNestedIfDemo_Click(object sender, EventArgs e)
        {
            // variables
            string userInput = string.Empty;  // Holds the user inputa string
            double userInputDouble = 0.0;     // Holds the user input if it converts to a Double
            int userInputint = 0;    // Holds the user input if it converts to a int
            string output = string.Empty;     // Holds the output to be displayed to the user

            // Enter a break point on userInput = tbNestedIfInput.Text and you can 
            // watch the execution of the code from start to finish
            // press...
            //   F10 - step over
            //   F11 - step into (this is when you want to step into functions)
            userInput = tbNestedIfInput.Text;  // Get the input from the text box

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputint))  // If the input is an int
                {

                    // create the message to be output to the user
                    // processing
                    output = userInputint.ToString("n0") + " = int";

                }
                else
                {
                    // create the message to be output to the user
                    // invalid input int required
                    output = "int required " + userInputDouble.ToString("n2") + " = Double";

                }

            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input int required
                output = "int required " + userInput + " = Not a Number (NaN)";

            }

            // output the message to the user
            lbNestedIfOutput.Text = output;

        }
        #endregion

        #region "for loop"

        /// <summary>
        /// Enter a number and click Enter. 
        /// This will Loop until the number 
        /// you have entered Is reached.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForLoopDemo_Click(object sender, EventArgs e)
        {

            // variables
            string userInput = string.Empty;  // Holds the user inputa string
            double userInputDouble = 0.0;    // Holds the user input if it converts to a Double
            int userInputInteger = 0;    // Holds the user input if it converts to a int
            string output = string.Empty;     // Holds the output to be displayed to the user

            userInput = tbForLoopDemoInput.Text;  // Get the input from the text box

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputInteger))  // If the input is an int
                {

                    // processing

                    // Enter a break point on For counterint = 1 To userInputint and you can 
                    // watch the execution of the code from start to finish
                    // press...
                    //   F10 - step over
                    //   F11 - step into (this is when you want to step into functions)

                    // loop starting at the number 1
                    // until the counter has reached
                    // the number the user has input

                    for (int counter = 1; counter <= userInputInteger; counter++)
                    {
                        output += counter.ToString() + " ";
                    }

                }
                else
                {
                    // create the message to be output to the user
                    // invalid input int required
                    output = "int required " + userInputDouble.ToString("n2") + " = Double";

                }

            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input int required
                output = "int required " + userInput + " = Not a Number (NaN)";

            }

            // output the message to the user
            lbForLoopDemoOutput.Text = output;

        }

        #endregion

        #region "for loop with break"
        /// <summary>
        /// Enter a number and click Enter. 
        /// This will Loop until the number entered  
        /// is reached or until the loop limit is reached.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnForLoopBreakDemo_Click(object sender, EventArgs e)
        {
            const int loopLimit = 20;

            // variables
            string userInput = string.Empty;  // Holds the user input as a string
            double userInputDouble = 0.0;    // Holds the user input if it converts to a Double
            int userInputInteger = 0;    // Holds the user input if it converts to a Integer
            string output = string.Empty;     // Holds the output to be displayed to the user

            userInput = tbForLoopBreakDemoInput.Text;  // Get the input from the text box

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputInteger))  // If the input is an Integer
                {

                    // processing

                    // Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                    // watch the execution of the code from start to finish
                    // press...
                    //   F10 - step over
                    //   F11 - step into (this is when you want to step into functions)

                    // loop starting at the number 1
                    // until the counter has reached
                    // the number the user has input
                    //For counter As Integer = 1 To loopLimit // initialize the variable and specifies the test
                    for (int counter = 1; counter <= loopLimit; counter++)
                    {
                        // append number to the output
                        output += counter.ToString() + " ";

                        // Check if the counter has reached 
                        // the user input
                        if (userInputInteger == counter)
                        {
                            // set the counter to the loopLimit
                            // to stop the loop
                            counter = loopLimit;

                            // no breaks or continues required

                        }

                    }
                }
                else
                {
                    // create the message to be output to the user
                    // invalid input integer required
                    output = "Integer required " + userInputDouble.ToString("n2") + " = Double";

                }

            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input integer required
                output = "Integer required " + userInput + " = Not a Number (NaN)";

            }

            // output the message to the user
            lbForLoopBreakDemoOutput.Text = output;

        }

        #endregion

        #region "while loop"
        /// <summary>
        /// Enter a number and click Enter. 
        /// This will Loop until the number 
        /// you have entered Is reached.
        /// </summary>
        /// <param name="sender"></param>
        private void btnWhileLoopDemo_Click(object sender, EventArgs e)
        {

            // variables
            string userInput = string.Empty;  // Holds the user input as a string
            double userInputDouble = 0.0;     // Holds the user input if it converts to a Double
            int userInputInteger = 0;     // Holds the user input if it converts to a Integer
            string output = string.Empty;     // Holds the output to be displayed to the user
            int counter = 1;              // Holds the an interger used to count 

            userInput = tbWhileLoopDemoInput.Text;  // Get the input from the text box

            if (Double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputInteger))  // If the input is an Integer
                {

                    // processing

                    // Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                    // watch the execution of the code from start to finish
                    // press...
                    //   F10 - step over
                    //   F11 - step into (this is when you want to step into functions)

                    // loop starting at the number 1
                    // until the counter has reached
                    // the number the user has input

                    while (counter <= userInputInteger)
                    {
                        // append number to the output
                        output += counter.ToString() + " ";

                        // increment counter
                        counter += 1;

                    }
                }
                else
                {
                    // create the message to be output to the user
                    // invalid input integer required
                    output = "Integer required " + userInputDouble.ToString("n2") + " = Double";

                }

            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input integer required
                output = "Integer required " + userInput + " = Not a Number (NaN)";

            }

            // output the message to the user
            lbWhileLoopDemoOutput.Text = output;

        }
        #endregion

        #region "while loop with break"

        /// <summary>
        /// Enter a number and click Enter. 
        /// This will Loop until the number entered  
        /// is reached or until the loop limit is reached.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnWhileLoopBreakDemo_Click(object sender, EventArgs e)
        {

            const int loopLimit = 15;

            // variables
            string userInput = string.Empty;  // Holds the user input as a string
            double userInputDouble = 0.0;     // Holds the user input if it converts to a Double
            int userInputInteger = 0;     // Holds the user input if it converts to a Integer
            string output = string.Empty;     // Holds the output to be displayed to the user
            int counter = 1;              // Holds the an interger used to count

            userInput = tbWhileLoopBreakDemoInput.Text;  // Get the input from the text box

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputInteger))  // If the input is an Integer
                {

                    // processing

                    // Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                    // watch the execution of the code from start to finish
                    // press...
                    //   F10 - step over
                    //   F11 - step into (this is when you want to step into functions)

                    // loop starting at the number 1
                    // until the counter has reached
                    // the number the user has input

                    while (counter <= loopLimit)
                    {
                        // append number to the output
                        output += counter.ToString() + " ";

                        // Check if the counter has reached 
                        // the user input
                        if (userInputInteger == counter)
                        {
                            // set the counter to the loopLimit
                            // to stop the loop
                            counter = loopLimit + 1;

                            // no breaks or continues required
                        }
                        else
                        {
                            // increment counter
                            counter += 1;

                        }
                    }
                }
                else
                {
                    // create the message to be output to the user
                    // invalid input integer required
                    output = "Integer required " + userInputDouble.ToString("n2") + " = Double";
                }
            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input integer required
                output = "Integer required " + userInput + " = Not a Number (NaN)";
            }

            // output the message to the user
            lbWhileLoopBreakDemoOutput.Text = output;




        }
        #endregion

        #region "do while loop"
        /// <summary>
        /// Enter a number and click Enter. 
        /// This will Loop until the number 
        /// you have entered Is reached.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoWhileLoopDemo_Click(object sender, EventArgs e)
        {

            // variables
            string userInput = string.Empty;  // Holds the user input as a string
            double userInputDouble = 0.0;     // Holds the user input if it converts to a Double
            int userInputInteger = 0;     // Holds the user input if it converts to a Integer
            string output = string.Empty;     // Holds the output to be displayed to the user
            int counter = 1;              // Holds the an interger used to count

            userInput = tbDoWhileLoopDemoInput.Text;  // Get the input from the text box

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputInteger))  // If the input is an Integer
                {

                    // processing

                    // Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                    // watch the execution of the code from start to finish
                    // press...
                    //   F10 - step over
                    //   F11 - step into (this is when you want to step into functions)

                    // loop starting at the number 1
                    // until the counter has reached
                    // the number the user has input
                    do
                    {

                        // append number to the output
                        output += counter.ToString() + " ";

                        // increment counter
                        counter += 1;
                    } while (counter <= userInputInteger);
                }
                else
                {
                    // create the message to be output to the user
                    // invalid input integer required
                    output = "Integer required " + userInputDouble.ToString("n2") + " = Double";

                }

            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input integer required
                output = "Integer required " + userInput + " = Not a Number (NaN)";

            }

            // output the message to the user
            lbDoWhileLoopDemoOutput.Text = output;

        }
        #endregion

        #region "do while loop with break"

        /// <summary>
        /// Enter a number and click Enter. 
        /// This will Loop until the number entered  
        /// is reached or until the loop limit is reached.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoWhileLoopBreakDemo_Click(object sender, EventArgs e)
        {

            const int loopLimit = 18;

            // variables
            string userInput = string.Empty;  // Holds the user input as a string
            double userInputDouble = 0.0;     // Holds the user input if it converts to a Double
            int userInputInteger = 0;     // Holds the user input if it converts to a Integer
            string output = string.Empty;     // Holds the output to be displayed to the user
            int counter = 1;              // Holds the an interger used to count

            userInput = tbDoWhileLoopBreakDemoInput.Text;  // Get the input from the text box

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputInteger))  // If the input is an Integer
                {

                    // processing

                    // Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                    // watch the execution of the code from start to finish
                    // press...
                    //   F10 - step over
                    //   F11 - step into (this is when you want to step into functions)

                    // loop starting at the number 1
                    // until the counter has reached
                    // the number the user has input
                    do
                    {

                        // append number to the output
                        output += counter.ToString() + " ";

                        if (userInputInteger == counter)
                        {

                            // set the counter to the loopLimit
                            // to stop the loop
                            counter = loopLimit;

                        }

                        // increment counter
                        counter += 1;

                    } while (counter <= loopLimit);
                }
                else
                {
                    // create the message to be output to the user
                    // invalid input integer required
                    output = "Integer required " + userInputDouble.ToString("n2") + " = Double";

                }

            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input integer required
                output = "Integer required " + userInput + " = Not a Number (NaN)";

            }

            // output the message to the user
            lbDoWhileLoopBreakDemoOutput.Text = output;


        }
        #endregion

        #region "create an array"

        /// <summary>
        /// Enter a number and click Enter. 
        /// This will create an array of the
        /// number of elements specified.
        /// Then each element of the array
        /// will be filled by looping the array
        /// and countingby 2s.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateArrayDemo_Click(object sender, EventArgs e)
        {

            const int minimumArraySize = 1;

            // variables
            string userInput = string.Empty;  // Holds the user input as a string
            double userInputDouble = 0.0;     // Holds the user input if it converts to a Double
            int userInputInteger = 0;     // Holds the user input if it converts to a Integer
            string output = string.Empty;     // Holds the output to be displayed to the user
            int[] demoArray;            // Holds calculated values that are calcualted during processing

            userInput = tbCreateArrayInput.Text;  // Get the input from the text box

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInput, out userInputInteger) && // If the input is an Integer
                   userInputInteger >= minimumArraySize)              // Also, there must be at least 1 element
                {
                    // processing

                    // create the array with the number of 
                    // elements specified by the user
                    demoArray = new int[userInputInteger];

                    // Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
                    // watch the execution of the code from start to finish
                    // press...
                    //   F10 - step over
                    //   F11 - step into (this is when you want to step into functions)

                    // loop starting at the number 0
                    // until the index has reached
                    // the length/size of the array
                    // -1. (Zero based index)
                    for (int index = 0; index < demoArray.Length; index++)
                    {
                        // append number to the output
                        demoArray[index] = (index + 1) * 2;

                    }

                    // loop starting at the number 0
                    // until the index has reached
                    // the length/size of the array
                    // -1. (Zero based index)
                    //For index As Integer = 0 To demoArray.Length - 1 // initialize the variable and specifies the test
                    for (int index = 0; index < demoArray.Length; index++)
                    {
                        // append number to the output
                        output += demoArray[index].ToString() + " ";

                    }
                }
                else
                {
                    // create the message to be output to the user
                    // invalid input integer required
                    output = "Arrays size must be an Integer/Whole number with a minimum value of " + minimumArraySize.ToString() + "\nYour input was " + userInputDouble.ToString("n0");

                }
            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input integer required
                output = "Integer required " + userInput + " = Not a Number (NaN)";

            }

            // output the message to the user
            lbCreateArrayOutput.Text = output;

        }
        #endregion

        #region "method demo"

        /// <summary>
        /// Enter a number and click Enter. 
        /// This will create an array of the
        /// number of elements specified.
        /// Then each element of the array
        /// will be filled by looping the array
        /// and counting by 2s.Uses a
        /// method to create the array and
        /// a method to create output.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMethodDemo_Click(object sender, EventArgs e)
        {

            // variables
            string userInput = string.Empty;  // Holds the user input as a string
            double userInputDouble = 0.0;     // Holds the user input if it converts to a Double
            int userInputInteger = 0;     // Holds the user input if it converts to a Integer
            string output = string.Empty;     // Holds the output to be displayed to the user
            int[] demoArray;            // Holds calculated values that are calcualted during processing

            // Input
            userInput = tbMethodInput.Text;  // Get the input from the text box

            // Input Validation
            if (IsValidInput(userInput, out userInputInteger) == true)
            {
                // Processing

                // Call the createAndLoadArray function/method 
                // which creates and loads the array based on the
                // array size and then assigns it to the demoArray.
                demoArray = CreateAndLoadArray(userInputInteger);

                // Output

                // Create the string output by calling
                // the function/method that creates the
                // output string and then assigns it to
                // the output variable.
                output = CreateOutput(demoArray);

                // output the message to the user
                lbMethodOutput.Text = output;

            }

        }

        /// <summary>
        /// IsValidInput - check the input to determine if it is a number and also confirms if it is a whole number.
        /// </summary>
        /// <param name="userInput">ByVal String</param>
        /// <param name="returnInputInteger">ByRef - Integer</param>
        /// <returns></returns>
        private bool IsValidInput(string userInput, out int validInputInteger)
        {

            const int minimumArraySize = 1;

            // variables
            double userInputDouble = 0.0;   // Holds the user input if it converts to a Double
            int userInputInteger = 0;       // Holds the user input if it converts to a Integer
            bool returnValue = true;         // Holds the value that return to the calling code True if it passed validation. False if it did not.
            string output = string.Empty;   // Holds the output to be displayed to the user

            if (double.TryParse(userInput, out userInputDouble))  // If the input is an Double
            {
                if (int.TryParse(userInputDouble.ToString(), out userInputInteger) && // If the input is an Integer
                   userInputInteger >= minimumArraySize)              // Also, there must be at least 1 element
                {

                    // set the valid input integer to be passed back to the calling code.
                    validInputInteger = userInputInteger;

                    // set the return boolean to true as it passed validation
                    returnValue = true;
                }
                else
                {
                    // create the message to be output to the user
                    // invalid input integer required
                    output = "Arrays size must be an Integer/Whole number with a minimum value of " + minimumArraySize.ToString() + "\nYour input was " + userInputDouble.ToString("n0");

                    // set the valid input integer to be passed back to the calling code.
                    validInputInteger = 0;

                    // set to false as it did not pass validation
                    returnValue = false;
                }
            }
            else // Otherwise the input is Not a Number
            {
                // create the message to be output to the user
                // invalid input integer required
                output = "Integer required " + userInput + " = Not a Number (NaN)";

                // set the valid input integer to be passed back to the calling code.
                validInputInteger = 0;

                // set to false as it did not pass validation
                returnValue = false;
            }


            // if the return value is false,
            // as it did not pass validation,
            //  show the message in the output
            //  label
            if (returnValue == false)
            {

                // output the message to the user
                lbMethodOutput.Text = output;

            }

            // return the boolean True if it passed validation, False if it did not
            return returnValue;

        }


        /// <summary>
        /// Function that accepts an integer representing the length 
        /// of size of the array. It creates the array and then proceeds
        /// to fill each element counting up by 2s.
        /// </summary>
        /// <param name="arrayLength"></param>
        /// <returns>array of type integer</returns>
        private int[] CreateAndLoadArray(int arrayLength)
        {
            // create the array with the number of 
            // elements specified by the user
            int[] returnArray = new int[arrayLength];

            // Enter a break point on For counter As Integer = 1 To userInputInteger and you can 
            // watch the execution of the code from start to finish
            // press...
            //   F10 - step over
            //   F11 - step into (this is when you want to step into functions)

            // loop starting at the number 0
            // until the index has reached
            // the length/size of the array
            // -1. (Zero based index)
            for (int index = 0; index < returnArray.Length; index++)
            {
                // append number to the output
                returnArray[index] = (index + 1) * 2;

            }

            // return the new array 
            // to the calling code
            return returnArray;

        }

        /// <summary>
        /// Function that accepts an integer array as an argument.
        /// It then loops through the array and create a string
        /// based on the values in the array.
        /// </summary>
        /// <param name="arrayOfValues">integer array</param>
        /// <returns>string</returns>
        private string CreateOutput(int[] arrayOfValues)
        {

            string returnValue = string.Empty;

            // loop starting at the number 0
            // until the index has reached
            // the length/size of the array
            // -1. (Zero based index)
            //For index As Integer = 0 To demoArray.Length - 1 // initialize the variable and specifies the test
            for (int index = 0; index < arrayOfValues.Length; index++)
            {
                // append number to the output
                returnValue += arrayOfValues[index].ToString() + " ";

            }

            // return the string that was
            // created from the array that 
            // was passed to the function/method
            return returnValue;
        }

        #endregion

        #region "reset form"
        /// <summary>
        /// The Click event of the reset button is fired when the
        /// user clicks the reset button when they wish to clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        /// <summary>
        /// Private function that loops through the form and
        /// determines if the control should be cleared. If so,
        /// the control is cleared.
        /// </summary>
        private void resetForm()
        {

            // declare a group box as 
            // all other controls are
            // within group boxes
            GroupBox groupBoxControl;

            // loop through each control that is directly
            // placed on the form (so the group boxes)
            foreach (object controlGroupBox in this.Controls)
            {

                // if it is a group box (which it will be)
                if (controlGroupBox is GroupBox)
                {

                    // Convert and assign the current control to the
                    // group box variable.
                    groupBoxControl = (GroupBox)controlGroupBox;

                    // Loop through the controls in the current group box
                    foreach (object control in groupBoxControl.Controls)
                    {

                        // if the control is a text box
                        if (control is TextBox)
                        {
                            // clear it
                            ((TextBox)control).Text = string.Empty;
                        }
                        else if (control is Label) // if the control is a label
                        {
                            // If the border style is Fixed3D, meaning we use it
                            // for output
                            if (((Label)control).BorderStyle == BorderStyle.Fixed3D)
                            {
                                // clear it 
                                ((Label)control).Text = string.Empty;
                                // all other labels will not be touched
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region "assign appropriate Accept Button"

        /// <summary>
        /// Captures the GotFocus event for a number of controls when a specific controls gets focus this reset the accept button
        /// to the appropriate button on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void input_GotFocus(Object sender, EventArgs e)
        {

            // Set the control name
            string controlName = ((TextBox)(sender)).Name;

            // check which text box has focus
            if (controlName == "tbIfInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnIfDemo;

            }
            else if (controlName == "tbNestedIfInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnNestedIfDemo;

            }
            else if (controlName == "tbForLoopDemoInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnForLoopDemo;

            }
            else if (controlName == "tbForLoopBreakDemoInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnForLoopBreakDemo;

            }
            else if (controlName == "tbWhileLoopDemoInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnWhileLoopDemo;

            }
            else if (controlName == "tbWhileLoopBreakDemoInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnWhileLoopBreakDemo;

            }
            else if (controlName == "tbDoWhileLoopDemoInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnDoWhileLoopDemo;

            }
            else if (controlName == "tbDoWhileLoopBreakDemoInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnDoWhileLoopBreakDemo;

            }
            else if (controlName == "tbCreateArrayInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnCreateArrayDemo;

            }
            else if (controlName == "tbMethodInput")
            {

                // set the accept button
                // to the appropriate button
                this.AcceptButton = btnMethodDemo;

            }
        }
        #endregion

        #region "close form"
        /// <summary>
        /// btnExit_Click - when click will call the form method to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the form 
            this.Close();

        }
        #endregion

    }
}
