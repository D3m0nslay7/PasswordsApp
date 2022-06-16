using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordsApp
{
    public partial class Form1 : Form
    {

        public class PasswordStructure
        {
            public string Password;

            public int lowercaseUsed;
            public int uppercaseUsed;
            public int numericalUsed;
            public int specialUsed; 

            public RadioButton button;

            public int RatingPoints;
            public int RemovingPoints;
            public string GivenRating;
        }

        //constants for the points removing and adding for characters.
        const int LowercaseAddPoints = 5;
        const int UppercaseAddPoints = 5;
        const int NumericalAddPoints = 10;
        const int SpecialAddPoints = 10;

        const int LowercaseRemovePoints = 3;
        const int UppercaseRemovePoints = 3;
        const int NumericalRemovePoints = 5;
        const int SpecialRemovePoints = 7;

        const int MaxPasswordLength = 15;
        const int MinPasswordLength = 8;

        const int BonusMinLength = 10;
        const int BonusPointsAddon = 20;
        private const string V = "Hi Welcome to the password tester, please input your password in the input section below!\nHowever please remember your password will be judged upon different things, each normal character gives you {0} points, numerical and special characters give you {1}\nYou will loose points if your entire password is only 1 type of characters, {2} points per character if its all lower or upper case, {3} points if its numerical characters and {4} points if its special characters\nyou will gain an extra {5} points if your character is above {6} characters,\nYou have to enter a miniumum of {7} characters and are only allowed a maximum of {8} characters.\n Thank you for using our password tester, Enjoy!";
        BindingList<PasswordStructure> PasswordsList = new BindingList<PasswordStructure>();
        List<char> specialCharacters = new List<char>();

        public PasswordStructure SelectedPassword = new PasswordStructure();

        public Form1()
        {
            specialCharacters.AddRange("!#$%&'()*+,-./:;<=>?@[]^_`{|}~");

            Console.WriteLine(specialCharacters);
            Console.ReadLine();

            PasswordsList.ListChanged += new ListChangedEventHandler(PasswordsList_ListChanged);

            InitializeComponent();

            //disables stuff
            #region HidingStuff

            LowerRemovePoints.Visible = false;
            UpperRemovePoints.Visible = false;
            NumericRemovePoints.Visible = false;
            RemovePointsSpecial.Visible = false;

            #endregion


            //sets the password entry box max text length to the constant we created
            PasswordEntryBox.MaxLength = MaxPasswordLength;

            this.PasswordEntryBox.KeyPress += PasswordEntryBox_KeyPress;
            //we want this to be false because we dont want the ui to show unless someone clicks a password button.
            BreakdownResultsGroup.Visible = false;
        }
        //generates the results for the password
        private void ShowPasswordResults()
        {
            //checks to see if the breakdown part is visible
            if (!BreakdownResultsGroup.Visible)
            {
                BreakdownResultsGroup.Visible = true;
            }

            int properResult = 0;

            //showing lowercase results
            LowercaseCharactersAmount.Text = "Characters: " + SelectedPassword.lowercaseUsed.ToString();
            LowercaseCharactersPoints.Text = "Points: " + (SelectedPassword.lowercaseUsed * LowercaseAddPoints).ToString();

            properResult = SelectedPassword.lowercaseUsed * LowercaseAddPoints;
            if (properResult > SelectedPassword.RatingPoints)
            {
                LowerRemovePoints.Visible = true;
                LowerRemovePoints.Text = "Removing " + SelectedPassword.RemovingPoints + " Points";
            }

            //showing uppercase results
            UppercaseCharactersAmount.Text = "Characters: " + SelectedPassword.uppercaseUsed.ToString();
            UppercaseCharactersPoints.Text = "Points: " + (SelectedPassword.uppercaseUsed * UppercaseAddPoints).ToString();


            properResult = SelectedPassword.uppercaseUsed * UppercaseAddPoints;
            if (properResult > SelectedPassword.RatingPoints)
            {
                UpperRemovePoints.Visible = true;
                UpperRemovePoints.Text = "Removing " + SelectedPassword.RemovingPoints + " Points";
            }

            //showing numerical results
            NumericalCharactersAmount.Text = "Characters: " + SelectedPassword.numericalUsed.ToString();
            NumericalCharactersPoints.Text = "Points: " + (SelectedPassword.numericalUsed * NumericalAddPoints).ToString();


            properResult = SelectedPassword.numericalUsed * NumericalAddPoints;
            if (properResult > SelectedPassword.RatingPoints)
            {
                NumericRemovePoints.Visible = true;
                NumericRemovePoints.Text = "Removing " + SelectedPassword.RemovingPoints + " Points";
            }

            //showing special characters results
            SpecialCharactersAmount.Text = "Characters: " + SelectedPassword.specialUsed.ToString();
            SpecialCharactersPoints.Text = "Points: " + (SelectedPassword.specialUsed * SpecialAddPoints).ToString();


            properResult = SelectedPassword.specialUsed * SpecialAddPoints;
            if (properResult > SelectedPassword.RatingPoints)
            {
                RemovePointsSpecial.Visible = true;
                RemovePointsSpecial.Text = "Removing " + SelectedPassword.RemovingPoints + " Points";
            }

            //showing Removing Results
            TotalPointsText.Text = "Total Points: " + SelectedPassword.RatingPoints;
        }

        //generates the results for the password
        private PasswordStructure GeneratePasswordResults(PasswordStructure password)
        {
            //cycles through the password and checks what each character is then adds it for the password value
            foreach (var character in password.Password)
            {
                switch (character)
                {
                    case char x when Char.IsDigit(character):
                        password.numericalUsed += 1;
                        break;
                    case char x when (Char.IsLower(character)):
                        password.lowercaseUsed += 1;
                        break;
                    case char x when (Char.IsUpper(character)):
                        password.uppercaseUsed += 1;
                        break;
                    case char x when (!Char.IsLetterOrDigit(character)):
                        password.specialUsed += 1;
                        break;
                    default:
                        break;
                }
            }

            //this formula gives the password its points
            password.RatingPoints += (password.numericalUsed * NumericalAddPoints) + (password.lowercaseUsed * LowercaseAddPoints) + (password.uppercaseUsed * UppercaseAddPoints) + (password.specialUsed * SpecialAddPoints);
            int pointsRemoved = 0;
            //this removes all the points the password should be deducted if they make a weak password using a certian character only. Also shows the ui for removing points
            switch (password)
            {
                case PasswordStructure pass when (pass.lowercaseUsed > 0 && pass.uppercaseUsed <= 0 && pass.numericalUsed <= 0 && pass.specialUsed <= 0):
                    pointsRemoved = (password.lowercaseUsed * LowercaseRemovePoints);
                    password.RatingPoints -= pointsRemoved;

                    password.RemovingPoints = pointsRemoved;
                    break;
                case PasswordStructure pass when (pass.lowercaseUsed <= 0 && pass.uppercaseUsed > 0 && pass.numericalUsed <= 0 && pass.specialUsed <= 0):
                    pointsRemoved = (password.uppercaseUsed * UppercaseRemovePoints);
                    password.RatingPoints -= pointsRemoved;

                    password.RemovingPoints = pointsRemoved;
                    break;
                case PasswordStructure pass when (pass.lowercaseUsed <= 0 && pass.uppercaseUsed <= 0 && pass.numericalUsed > 0 && pass.specialUsed <= 0):
                    pointsRemoved = (password.numericalUsed * NumericalRemovePoints);
                    password.RatingPoints -= pointsRemoved;

                    password.RemovingPoints = pointsRemoved;
                    break;
                case PasswordStructure pass when (pass.lowercaseUsed <= 0 && pass.uppercaseUsed <= 0 && pass.numericalUsed <= 0 && pass.specialUsed > 0):
                    pointsRemoved = (password.specialUsed * SpecialRemovePoints);
                    password.RatingPoints -= pointsRemoved;

                    password.RemovingPoints = pointsRemoved;
                    break;
                default:
                    break;
            }


            //this gives the password its correct standing based upon the points it recieved.
            switch (password.RatingPoints)
            {
                case int x when x > 81:
                    password.GivenRating = "Very High";
                    break;
                case int x when x > 70:
                    password.GivenRating = "High";
                    break;
                case int x when x > 41:
                    password.GivenRating = "Medium";
                    break;
                case int x when x > 21:
                    password.GivenRating = "Low";
                    break;
                default:
                    password.GivenRating = "Very Low";
                    break;
            }


            return password;
        }

        private void PasswordsList_ListChanged(object sender, ListChangedEventArgs e)
        {
            //use e.ListChangedType property to determine if a row was added
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                // richTextBox1.Text = "Password added, it worked";

                //Calls the function that makes new radio buttons for the password we just added
                RadioButtonPasswordCreator(PasswordsList.Last());
            }

        }

        //takes the password that was just added
        private void RadioButtonPasswordCreator(PasswordStructure password)
        {
            RadioButton NewRadioButton = new RadioButton
            {
                Name = password.Password + "RadioButton",
                Text = password.Password
            };
            password.button = NewRadioButton;
            NewRadioButton.TabIndex = 5;
            NewRadioButton.TabStop = true;
            NewRadioButton.UseVisualStyleBackColor = true;
            NewRadioButton.Parent = PasswordChoosingHolder;
            NewRadioButton.CheckedChanged += new EventHandler(PasswordRadioButton_CheckedChanged);
            
            
        }
            
        public void PasswordRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // We get the selected password and assign it to the selected password so we know what password was selected
                foreach (var pass in PasswordsList)
                {
                    if (pass.Password == rb.Text)
                    {
                        SelectedPassword = pass;
                        //calls the password generating result
                        ShowPasswordResults();
                    }
                }    
            }
        }

        private void PasswordEntryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //richTextBox1.Text = "awdada";
            if (e.KeyChar == (char)13)
            {
                //richTextBox1.Text = "aaaaaaaaaaaaaa";
                string input = PasswordEntryBox.Text;
                //PasswordEntryBox.Text = "";
                //checks the input for length maximum
                if (input.Length < MinPasswordLength && input.Length > MaxPasswordLength)
                {
                    MessageBox.Show("Please input a password with a minimum of 8 characters and maximum of 15.");
                    return;
                }

                //checks the input for special characters
                foreach (var character in input)
                {
                    if (!Char.IsLetterOrDigit(character))
                    {
                        bool specialCheck = false;
                        for (int i = 0; i < specialCharacters.Count; i++)
                        {
                            if (character == specialCharacters[i])
                            {
                                specialCheck = true;
                                break;
                            }                        
                        }

                        if (specialCheck == false)
                        {
                            MessageBox.Show("Please Input a password using our guide");
                            return;
                        }
                    }
                    
                    
                }

                PasswordStructure pass = new PasswordStructure();
                pass.Password = PasswordEntryBox.Text;

                //generates the results for this password and adds it at hte same time
                PasswordsList.Add(GeneratePasswordResults(pass));

                //MessageBox.Show(PasswordsList.Last().GivenRating + "\n" + PasswordsList.Last().RatingPoints + "\n" + PasswordsList.Last().lowercaseUsed + "\n" + PasswordsList.Last().uppercaseUsed + "\n" + PasswordsList.Last().numericalUsed + "\n" + PasswordsList.Last().specialUsed);

                PasswordEntryBox.Text = "";
            }
            
        }

        private void CompletedCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordEntry.Visible = false;
        }

    }
}
