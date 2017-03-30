using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;


namespace Homework4
{
    public class ZipCodeTextBox : TextBox
    {

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            //Allow for canadian postal code only
            var sender = (ZipCodeTextBox)e.Source;
            StringBuilder text = new StringBuilder(sender.Text);

            if (sender.CaretIndex >= sender.Text.Length)
            {
                text.Append(e.Text[0]);
            }
            e.Handled = !IsValid(text.ToString()); //If it is not valid then close the gate-e.handled is a gate keeper-
            base.OnPreviewTextInput(e);
        }

        private bool IsValid(string postalcode)
        {
            //Check the postal code length
            if (postalcode.Length > 6) { return false; }

            bool shouldBeAlpha = true;

            foreach (var ch in postalcode)
            {
                if (shouldBeAlpha) //check if it should be a letter
                {
                    shouldBeAlpha = false; //the next one should not be a letter so it's false
                    if (!char.IsLetter(ch)) //If it is not a letter then it is not valid
                    {
                        return false;
                    }
                }
                else
                {
                    shouldBeAlpha = true; //Next one should be a letter
                    if (!char.IsDigit(ch)) //If it is not a digit then it is not valid
                    {
                        return false;
                    }
                }
            }
            return true; //Otherwise is always valid
        }//end of canadian postal code
    }
}
