using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Conversions.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        string UnitConvOne = "";
        string UnitConvTwo = "";
        double Input;
        double Output;
        public AboutPage()
        {
            InitializeComponent();

            ConversionType.Items.Add("Volume");
            ConversionType.Items.Add("Mass");

        }

        private void btnConvert_Clicked(object sender, EventArgs e)
        {
            try
            {
                UnitConvOne = this.PickUnitOne.SelectedItem.ToString();
                UnitConvTwo = this.PickUnitTwo.SelectedItem.ToString();
            }
            catch
            {
                DisplayAlert("Error", "Don't leave the First Box Empty when trying to Convert", "Okay");
            }
            try
            {
                Input = double.Parse(UnitOne.Text);
            }
            catch
            {
                DisplayAlert("Error", "Please enter numbers not letters", "Okay");
            }
            double Calculation = ConvertValues(UnitConvOne, UnitConvTwo, Input, Output);
            UnitTwo.Text = Calculation.ToString();
        }

        private double ConvertValues(string UnitOne, string UnitTwo, double Input, double Output)
        {
            
            //Values
            if (UnitOne == "None" || UnitOne == null)
            {
                DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                Output = 0;
            }
            //
            else if (UnitOne == "teaspoon")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input;
                        break;
                    case "tablespoon":
                        Output = Input * 0.333333;
                        break;
                    case "fluid ounce":
                        Output = Input * 0.166667;
                        break;
                    case "cup":
                        Output = Input * 0.0205372;
                        break;
                    case "pint":
                        Output = Input * 0.0205372;
                        break;
                    case "quart":
                        Output = Input * 0.00520833;
                        break;
                    case "milliliters":
                        Output = Input * 4.92892;
                        break;
                    case "liters":
                        Output = Input * 0.00492892;
                        break;
                }
            }
            //
            else if (UnitOne == "tablespoon")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input * 3;
                        break;
                    case "tablespoon":
                        Output = Input;
                        break;
                    case "fluid ounce":
                        Output = Input * 0.5;
                        break;
                    case "cup":
                        Output = Input * 0.0616115;
                        break;
                    case "pint":
                        Output = Input * 0.03125;
                        break;
                    case "quart":
                        Output = Input * 0.015625;
                        break;
                    case "milliliters":
                        Output = Input * 14.7868;
                        break;
                    case "liters":
                        Output = Input * 0.0147868;
                        break;
                }
            }
            //
            else if (UnitOne == "fluid ounce")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input * 6;
                        break;
                    case "tablespoon":
                        Output = Input * 2;
                        break;
                    case "fluid ounce":
                        Output = Input;
                        break;
                    case "cup":
                        Output = Input * 0.123223;
                        break;
                    case "pint":
                        Output = Input * 0.0625;
                        break;
                    case "quart":
                        Output = Input * 0.03125;
                        break;
                    case "milliliters":
                        Output = Input * 29.5735;
                        break;
                    case "liters":
                        Output = Input * 0.0295735;
                        break;
                }
            }
            //
            else if (UnitOne == "cup")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input * 48.6922;
                        break;
                    case "tablespoon":
                        Output = Input * 16.2307;
                        break;
                    case "fluid ounce":
                        Output = Input * 8.11537;
                        break;
                    case "cup":
                        Output = Input;
                        break;
                    case "pint":
                        Output = Input * 0.50721;
                        break;
                    case "quart":
                        Output = Input * 0.253605;
                        break;
                    case "milliliters":
                        Output = Input * 240;
                        break;
                    case "liters":
                        Output = Input * 0.24;
                        break;
                }
            }
            //
            else if (UnitOne == "pint")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input * 96;
                        break;
                    case "tablespoon":
                        Output = Input * 32;
                        break;
                    case "fluid ounce":
                        Output = Input * 16;
                        break;
                    case "cup":
                        Output = Input * 1.97157;
                        break;
                    case "pint":
                        Output = Input;
                        break;
                    case "quart":
                        Output = Input * 0.5;
                        break;
                    case "milliliters":
                        Output = Input * 473.176;
                        break;
                    case "liters":
                        Output = Input * 0.473176;
                        break;
                }
            }
            //
            else if (UnitOne == "quart")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input * 192;
                        break;
                    case "tablespoon":
                        Output = Input * 64;
                        break;
                    case "fluid ounce":
                        Output = Input * 32;
                        break;
                    case "cup":
                        Output = Input * 3.94314;
                        break;
                    case "pint":
                        Output = Input * 2;
                        break;
                    case "quart":
                        Output = Input;
                        break;
                    case "milliliters":
                        Output = Input * 946.353;
                        break;
                    case "liters":
                        Output = Input * 0.946353;
                        break;
                }
            }
            //
            else if (UnitOne == "milliliters")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input * 0.202884;
                        break;
                    case "tablespoon":
                        Output = Input * 0.067628;
                        break;
                    case "fluid ounce":
                        Output = Input * 0.033814;
                        break;
                    case "cup":
                        Output = Input * 0.00416667;
                        break;
                    case "pint":
                        Output = Input * 0.00211338;
                        break;
                    case "quart":
                        Output = Input * 0.00105669;
                        break;
                    case "milliliters":
                        Output = Input;
                        break;
                    case "liters":
                        Output = Input * 0.001;
                        break;
                }
            }
            //
            else if (UnitOne == "liters")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "teaspoon":
                        Output = Input * 202.884;
                        break;
                    case "tablespoon":
                        Output = Input * 67.628;
                        break;
                    case "fluid ounce":
                        Output = Input * 33.814;
                        break;
                    case "cup":
                        Output = Input * 4.16667;
                        break;
                    case "pint":
                        Output = Input * 2.11338;
                        break;
                    case "quart":
                        Output = Input * 1.05669;
                        break;
                    case "milliliters":
                        Output = Input * 1000;
                        break;
                    case "liters":
                        Output = Input;
                        break;
                }
            }


            //Mass
            else if (UnitOne == "ounce")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "ounce":
                        Output = Input;
                        break;
                    case "pound":
                        Output = Input * 0.0625;
                        break;
                    case "milligrams":
                        Output = Input * 28349.5;
                        break;
                    case "grams":
                        Output = Input * 28.3495;
                        break;
                    case "kilograms":
                        Output = Input * 0.0283495;
                        break;
                }
            }
            //
            else if (UnitOne == "pound")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "ounce":
                        Output = Input * 16;
                        break;
                    case "pound":
                        Output = Input;
                        break;
                    case "milligrams":
                        Output = Input * 453592;
                        break;
                    case "grams":
                        Output = Input * 453.592;
                        break;
                    case "kilograms":
                        Output = Input * 0.453592;
                        break;
                }
            }
            //
            else if (UnitOne == "milligrams")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "ounce":
                        Output = Input * 0.000035274;
                        break;
                    case "pound":
                        Output = Input * 0.0000022046;
                        break;
                    case "milligrams":
                        Output = Input;
                        break;
                    case "grams":
                        Output = Input * 0.001;
                        break;
                    case "kilograms":
                        Output = Input * .0000001;
                        break;
                }
            }
            //
            else if (UnitOne == "grams")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "ounce":
                        Output = Input * 0.035274;
                        break;
                    case "pound":
                        Output = Input * 0.00220462;
                        break;
                    case "milligrams":
                        Output = Input * 1000;
                        break;
                    case "grams":
                        Output = Input;
                        break;
                    case "kilograms":
                        Output = Input * 0.001;
                        break;
                }
            }
            //
            else if (UnitOne == "kilograms")
            {
                switch (UnitTwo)
                {
                    case null:
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "none":
                        DisplayAlert("No Conversion Requested", "You Did Not Request To Convert A Unit", "Okay");
                        Output = 0;
                        break;
                    case "ounce":
                        Output = Input * 35.274;
                        break;
                    case "pound":
                        Output = Input * 2.20462;
                        break;
                    case "milligrams":
                        Output = Input * 1000000;
                        break;
                    case "grams":
                        Output = Input * 1000;
                        break;
                    case "kilograms":
                        Output = Input;
                        break;
                }
            }
            
            //
            return Output;
        }

        private void ChooseConversion(string ConvertType)
        {
            PickUnitOne.Items.Clear();
            PickUnitTwo.Items.Clear();

            if (ConvertType == "Volume")
            {
                PickUnitOne.Items.Add("None");
                PickUnitOne.Items.Add("teaspoon");
                PickUnitOne.Items.Add("tablespoon");
                PickUnitOne.Items.Add("fuild ounce");
                PickUnitOne.Items.Add("cup");
                PickUnitOne.Items.Add("pint");
                PickUnitOne.Items.Add("quart");
                PickUnitOne.Items.Add("milliliters");
                PickUnitOne.Items.Add("liters");

                PickUnitTwo.Items.Add("None");
                PickUnitTwo.Items.Add("teaspoon");
                PickUnitTwo.Items.Add("tablespoon");
                PickUnitTwo.Items.Add("fuild ounce");
                PickUnitTwo.Items.Add("cup");
                PickUnitTwo.Items.Add("pint");
                PickUnitTwo.Items.Add("quart");
                PickUnitTwo.Items.Add("milliliters");
                PickUnitTwo.Items.Add("liters");
            }


            else if (ConvertType == "Mass")
            {
                PickUnitOne.Items.Add("None");
                PickUnitOne.Items.Add("ounce");
                PickUnitOne.Items.Add("pound");
                PickUnitOne.Items.Add("milligrams");
                PickUnitOne.Items.Add("grams");
                PickUnitOne.Items.Add("kilograms");

                PickUnitTwo.Items.Add("None");
                PickUnitTwo.Items.Add("ounce");
                PickUnitTwo.Items.Add("pound");
                PickUnitTwo.Items.Add("milligrams");
                PickUnitTwo.Items.Add("grams");
                PickUnitTwo.Items.Add("kilograms");
            }
        }

        private void ConversionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ConvertType = this.ConversionType.SelectedItem.ToString();
            ChooseConversion(ConvertType);
        }
    }
}