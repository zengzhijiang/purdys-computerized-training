// Purdy's Computerized Training Program
// Developed by Arianna Bryant, Jinxian Zhu, Binpeng Liu, and Zengzhi Jiang
// Commented and Completed December 12th, 2018

using System;
using System.Collections.Generic;

// This program was developed in order for coaches or runners alike to input their information and thereby retrieve a table that
// shows what a runner should be able to run for any event given their abilities.  It also allows for the percentage of effort,
// or "Performance Percentage" to be manipulated and give coaches and runners the edited times for a "less-exerting" rep.

public partial class Default : System.Web.UI.Page
{
    // Up here we explain and initialize a few key variables that will be needed prior to the calculations:

    // Events - This string array holds the name of every possible event choice a user can choose
    static string[] Events;

    // DistanceArray - This double array holds the distance equivalent for each event in meters
    // C1Arr - This double array holds all of the constant values for "C1" as explained in the readme document under "Purdy Research"
    // C2Arr - This double array holds all of the constant values for "C2" as explained in the readme document under "Purdy Research"
    // C3Arr - This double array holds all of the constant values for "C3" as explained in the readme document under "Purdy Research"
    // PtLvl1400 - This double array holds all of the velocities for its respective event given that the velocity would result
    //  in a Purdy Point value equal to 1400 as explained in the readme document under "Purdy Research"
    // ZeroOff - This double array holds all of the velocities for its respective event given that the velocity would result
    //  in a Purdy Point value equal to 0 as explained in the readme document under "Purdy Research"
    static double[] DistanceArray, C1Arr, C2Arr, C3Arr, PtLvl1400, ZeroOff;

    // CVal1 - This dictionary is created with the intent to link the Events array with the respective "C1" constant value;
    //  the key is set to be the event name as a string, and the value is set as the corresponding "C1" value
    // CVal2 - This dictionary is created with the intent to link the Events array with the respective "C2" constant value;
    //  the key is set to be the event name as a string, and the value is set as the corresponding "C2" value
    // CVal3 - This dictionary is created with the intent to link the Events array with the respective "C3" constant value;
    //  the key is set to be the event name as a string, and the value is set as the corresponding "C3" value
    // PtVal - This dictionary is created with the intent to link the Events array with the respective 1400 Point level velocity;
    //  the key is set to be the event name as a string, and the value is set as the corresponding 1400 Point level velocity value
    // CVal3 - This dictionary is created with the intent to link the Events array with the respective Zero Offset velocity;
    //  the key is set to be the event name as a string, and the value is set as the corresponding Zero Offset velocity value
    static Dictionary<string, double> CVal1, CVal2, CVal3, PtVal, ZVal; 

    protected void Page_Load(object sender, EventArgs e)
    {
        // Here as the page loads, all the variables initialized above are set and given values to define them.

        Events = new string[] { "100yd", "100m", "200m", "400m", "800m", "1500m", "One Mile", "5000m", "10000m", "Marathon",
            "110m HH", "400m IH", "3000m SC", "400m Relay", "1600m Relay" };

        DistanceArray = new double[] { 91.44, 100, 200, 400, 800, 1500, 1609.34, 5000, 10000, 42195, 110, 400, 3000, 400, 1600 };

        CVal1 = new Dictionary<string, double>();

        C1Arr = new double[] { 851.88528, 839.75428, 881.70483, 1047.9015,
            1131.6133, 1164.4589, 1168.6261, 1179.3839, 1152.9698, 1195.5466,
            915.40060, 911.61065, 1381.5344, 879.66309, 939.19286 };

        CVal1.Add("100yd", C1Arr[0]);
        CVal1.Add("100m", C1Arr[1]);
        CVal1.Add("200m", C1Arr[2]);
        CVal1.Add("400m", C1Arr[3]);
        CVal1.Add("800m", C1Arr[4]);
        CVal1.Add("1500m", C1Arr[5]);
        CVal1.Add("One Mile", C1Arr[6]);
        CVal1.Add("5000m", C1Arr[7]);
        CVal1.Add("10000m", C1Arr[8]);
        CVal1.Add("Marathon", C1Arr[9]);
        CVal1.Add("110m HH", C1Arr[10]);
        CVal1.Add("400m IH", C1Arr[11]);
        CVal1.Add("3000m SC", C1Arr[12]);
        CVal1.Add("400m Relay", C1Arr[13]);
        CVal1.Add("1600m Relay", C1Arr[14]);

        CVal2 = new Dictionary<string, double>();

        C2Arr = new double[] { 0.0011643153, 0.0031833857, 0.014162419,
            0.000021175050, 0.00000084512363, 0.00023040003, 0.00035898808,
            0.0026071613, 0.011470485, 0.067257161, 0.077499020, 0.092208460,
            0.021066044, 0.0017573247, 0.0055475673 };

        CVal2.Add("100yd", C2Arr[0]);
        CVal2.Add("100m", C2Arr[1]);
        CVal2.Add("200m", C2Arr[2]);
        CVal2.Add("400m", C2Arr[3]);
        CVal2.Add("800m", C2Arr[4]);
        CVal2.Add("1500m", C2Arr[5]);
        CVal2.Add("One Mile", C2Arr[6]);
        CVal2.Add("5000m", C2Arr[7]);
        CVal2.Add("10000m", C2Arr[8]);
        CVal2.Add("Marathon", C2Arr[9]);
        CVal2.Add("110m HH", C2Arr[10]);
        CVal2.Add("400m IH", C2Arr[11]);
        CVal2.Add("3000m SC", C2Arr[12]);
        CVal2.Add("400m Relay", C2Arr[13]);
        CVal2.Add("1600m Relay", C2Arr[14]);

        CVal3 = new Dictionary<string, double>();

        C3Arr = new double[] { 16.72092, 15.415497, 13.487407, 22.084218,
            27.394097, 20.538790, 19.974554, 17.831672, 15.899776, 12.725493,
            12.025866, 11.805470, 14.743573, 15.941420, 15.054013 };

        CVal3.Add("100yd", C3Arr[0]);
        CVal3.Add("100m", C3Arr[1]);
        CVal3.Add("200m", C3Arr[2]);
        CVal3.Add("400m", C3Arr[3]);
        CVal3.Add("800m", C3Arr[4]);
        CVal3.Add("1500m", C3Arr[5]);
        CVal3.Add("One Mile", C3Arr[6]);
        CVal3.Add("5000m", C3Arr[7]);
        CVal3.Add("10000m", C3Arr[8]);
        CVal3.Add("Marathon", C3Arr[9]);
        CVal3.Add("110m HH", C3Arr[10]);
        CVal3.Add("400m IH", C3Arr[11]);
        CVal3.Add("3000m SC", C3Arr[12]);
        CVal3.Add("400m Relay", C3Arr[13]);
        CVal3.Add("1600m Relay", C3Arr[14]);

        PtVal = new Dictionary<string, double>();

        PtLvl1400 = new double[] { 9.8746, 10.0192, 10.0262, 8.9108, 7.7066, 6.9992,
            6.9458, 6.3102, 6.0215, 5.4110, 8.2645, 8.2457, 6.1206, 10.3923,
            8.9092 };

        PtVal.Add("100yd", PtLvl1400[0]);
        PtVal.Add("100m", PtLvl1400[1]);
        PtVal.Add("200m", PtLvl1400[2]);
        PtVal.Add("400m", PtLvl1400[3]);
        PtVal.Add("800m", PtLvl1400[4]);
        PtVal.Add("1500m", PtLvl1400[5]);
        PtVal.Add("One Mile", PtLvl1400[6]);
        PtVal.Add("5000m", PtLvl1400[7]);
        PtVal.Add("10000m", PtLvl1400[8]);
        PtVal.Add("Marathon", PtLvl1400[9]);
        PtVal.Add("110m HH", PtLvl1400[10]);
        PtVal.Add("400m IH", PtLvl1400[11]);
        PtVal.Add("3000m SC", PtLvl1400[12]);
        PtVal.Add("400m Relay", PtLvl1400[13]);
        PtVal.Add("1600m Relay", PtLvl1400[14]);

        ZVal = new Dictionary<string, double>();

        ZeroOff = new double[] { 1.9991, 1.9990, 1.9980, 1.9960, 1.9920, 1.9850,
            1.9839, 1.9500, 1.9000, 1.5778, 1.9989, 1.9960, 1.9700, 1.9960, 1.9840 };

        ZVal.Add("100yd", ZeroOff[0]);
        ZVal.Add("100m", ZeroOff[1]);
        ZVal.Add("200m", ZeroOff[2]);
        ZVal.Add("400m", ZeroOff[3]);
        ZVal.Add("800m", ZeroOff[4]);
        ZVal.Add("1500m", ZeroOff[5]);
        ZVal.Add("One Mile", ZeroOff[6]);
        ZVal.Add("5000m", ZeroOff[7]);
        ZVal.Add("10000m", ZeroOff[8]);
        ZVal.Add("Marathon", ZeroOff[9]);
        ZVal.Add("110m HH", ZeroOff[10]);
        ZVal.Add("400m IH", ZeroOff[11]);
        ZVal.Add("3000m SC", ZeroOff[12]);
        ZVal.Add("400m Relay", ZeroOff[13]);
        ZVal.Add("1600m Relay", ZeroOff[14]);

    }

    // Once the user inputs their data and hits the submit button, this module will be ran and begin its functions: abstractly,
    // the purpose of this module encompasses the purpose of the program in its entirety.
    public void Gen_Table(object sender, EventArgs e)
    {
        // The following variables are explained and initialized for use in the generation of the outputted table

        // Event - This string is equivalent to the event the user selected from the drop down box
        string Event = eventstr.Items[eventstr.SelectedIndex].Value;

        // Pt1400 - This double's value is set below in the switch as the appropriate value for the 1400 Point Level velocity of
        //  the event, given the key for the dictionary of "PtVal".
        // Zero - This double's value is set below in the switch as the appropriate value for the Zero Offset velocity of the event,
        //  given the key for the dictionary of "ZVal".
        // C1 - This double's value is set below in the switch as the appropriate value for the "C1" constant value of the event,
        //  given the key for the dictionary of "CVal1".
        // C2 - This double's value is set below in the switch as the appropriate value for the "C2" constant value of the event,
        //  given the key for the dictionary of "CVal2".
        // C3 - This double's value is set below in the switch as the appropriate value for the "C3" constant value of the event,
        //  given the key for the dictionary of "CVal3".
        // Distance - This double's value is set below in the switch as the appropriate value for the "Distance" constant value
        //  of the event, which linearly increases the index of "DistanceArray" used.  This is not set in a dictionary like the
        //  others due to the fact that it is needed to be used like an array later in future calculations and it was easier to
        //  iterate through an array than a dictionary
        // TotalTime - This double is initialized and set to 1 here as it is necessary to set the time to some value to stop a
        //  null exception from occuring in the code.  User's are still alerted about a missing time input, but the code will not
        //  hang or exit unexpectedly.  The TotalTime will be reassigned an appropriate value later based on user input
        double Pt1400, Zero, C1, C2, C3, Distance, TotalTime = 1;

        // PerfTo - This double is set to the value of the user's input for the percentage performance velocities the user would
        //  like to see in the table.  This performance entry refers to the highest performance desired by the user.  The value
        //  must be divided by 100 as the value is set to be the numerical equivalent of the user's entry (e.g. "100%" has a value of 100)
        //  This could easily be remedied if not slightly time consuming as 100 values would need to be edited.
        // PerfFrom - This double is set to the value of the user's input for the percentage performance velocities the user would
        //  like to see in the table.  This performance entry refers to the lowest performance desired by the user.  The value
        //  must be divided by 100 as the value is set to be the numerical equivalent of the user's entry (e.g. "100%" has a value of 100)
        // Increment - This double value is to what increment the user would like to jump between percentage performance velocities; for
        //  example: a user who wishes to see 95-100 by "1%" will see 95, 96, 97, 98, 99, and 100, whereas a user who wishes to see 95-100
        //  by "5%" will see 95 and 100.
        double PerfTo = Convert.ToDouble(to.Value) / 100, PerfFrom = Convert.ToDouble (from.Value)/100, 
            Increment = Convert.ToDouble(increment.Value);

        // This switch statement takes a look at the Event variable set above and uses the case assigned to it in order to set the
        //  appropriate values for the unset variables.
        switch (Event)
        {
            case "100yd":

                Pt1400 = PtVal["100yd"];
                Zero = ZVal["100yd"];
                C1 = CVal1["100yd"];
                C2 = CVal2["100yd"];
                C3 = CVal3["100yd"];
                Distance = DistanceArray[0];
                break;

            case "100m":
                Pt1400 = PtVal["100m"];
                Zero = ZVal["100m"];
                C1 = CVal1["100m"];
                C2 = CVal2["100m"];
                C3 = CVal3["100m"];
                Distance = DistanceArray[1];
                break;

            case "200m":
                Pt1400 = PtVal["200m"];
                Zero = ZVal["200m"];
                C1 = CVal1["200m"];
                C2 = CVal2["200m"];
                C3 = CVal3["200m"];
                Distance = DistanceArray[2];
                break;

            case "400m":
                Pt1400 = PtVal["400m"];
                Zero = ZVal["400m"];
                C1 = CVal1["400m"];
                C2 = CVal2["400m"];
                C3 = CVal3["400m"];
                Distance = DistanceArray[3];
                break;

            case "800m":
                Pt1400 = PtVal["800m"];
                Zero = ZVal["800m"];
                C1 = CVal1["800m"];
                C2 = CVal2["800m"];
                C3 = CVal3["800m"];
                Distance = DistanceArray[4];
                break;

            case "1500m":
                Pt1400 = PtVal["1500m"];
                Zero = ZVal["1500m"];
                C1 = CVal1["1500m"];
                C2 = CVal2["1500m"];
                C3 = CVal3["1500m"];
                Distance = DistanceArray[5];
                break;

            case "One Mile":
                Pt1400 = PtVal["One Mile"];
                Zero = ZVal["One Mile"];
                C1 = CVal1["One Mile"];
                C2 = CVal2["One Mile"];
                C3 = CVal3["One Mile"];
                Distance = DistanceArray[6];
                break;

            case "5000m":
                Pt1400 = PtVal["5000m"];
                Zero = ZVal["5000m"];
                C1 = CVal1["5000m"];
                C2 = CVal2["5000m"];
                C3 = CVal3["5000m"];
                Distance = DistanceArray[7];
                break;

            case "10000m":
                Pt1400 = PtVal["10000m"];
                Zero = ZVal["10000m"];
                C1 = CVal1["10000m"];
                C2 = CVal2["10000m"];
                C3 = CVal3["10000m"];
                Distance = DistanceArray[8];
                break;

            case "Marathon":
                Pt1400 = PtVal["Marathon"];
                Zero = ZVal["Marathon"];
                C1 = CVal1["Marathon"];
                C2 = CVal2["Marathon"];
                C3 = CVal3["Marathon"];
                Distance = DistanceArray[9];
                break;

            case "110m HH":
                Pt1400 = PtVal["110m HH"];
                Zero = ZVal["110m HH"];
                C1 = CVal1["110m HH"];
                C2 = CVal2["110m HH"];
                C3 = CVal3["110m HH"];
                Distance = DistanceArray[10];
                break;

            case "400m IH":
                Pt1400 = PtVal["400m IH"];
                Zero = ZVal["400m IH"];
                C1 = CVal1["400m IH"];
                C2 = CVal2["400m IH"];
                C3 = CVal3["400m IH"];
                Distance = DistanceArray[11];
                break;

            case "3000m SC":
                Pt1400 = PtVal["3000m SC"];
                Zero = ZVal["3000m SC"];
                C1 = CVal1["3000m SC"];
                C2 = CVal2["3000m SC"];
                C3 = CVal3["3000m SC"];
                Distance = DistanceArray[12];
                break;

            case "400m Relay":
                Pt1400 = PtVal["400m Relay"];
                Zero = ZVal["400m Relay"];
                C1 = CVal1["400m Relay"];
                C2 = CVal2["400m Relay"];
                C3 = CVal3["400m Relay"];
                Distance = DistanceArray[13];
                break;

            case "1600m Relay":
                Pt1400 = PtVal["1600m Relay"];
                Zero = ZVal["1600m Relay"];
                C1 = CVal1["1600m Relay"];
                C2 = CVal2["1600m Relay"];
                C3 = CVal3["1600m Relay"];
                Distance = DistanceArray[14];
                break;
            
            // Given that no values were set, there will be an error given to the user, along with the catch preventing further
            //  calculations from occurring
            default:
                table.InnerHtml = "Error Loading Workout Table, please refresh and try again.";
                Pt1400 = 0;
                Zero = 0;
                C1 = 0;
                C2 = 0;
                C3 = 0;
                Distance = 0;
                break;
        }

        try
        {
            // h, m, and s - These integers are initialized here rather than above as it is possible for someone to input
            //  no time (0's across the board).  By initializing the variables here, we can keep them in the try/catch, which
            //  is slightly obsolete given our data is now given from drop down selections, but is best to leave it here in case
            //  someone found a way to try to input invalid data by some form of injection
            // Each integer variable is equal to its respective time value inputted by the user
            int h = Convert.ToInt32(hour.Value);
            int m = Convert.ToInt32(minute.Value);
            int s = Convert.ToInt32(second.Value);

            // This is used to check for if a user mistakenly or intentionally input no time for their event.  The code
            // within acts as an "on/off switch" for an alert that will display when appropriate an alert to input a time
            if (h == 0 && m == 0 && s == 0)
            {
                alert.Style["display"] = "block";
                alert.InnerHtml = "Please input your time.";
            }
            else
            {
                alert.Style["display"] = "none";

                // TotalTime - This calculation is the standard for converting hours and minutes into seconds, and then
                //  adding the seconds as well.
                TotalTime = (Convert.ToDouble(h) * 3600) + (Convert.ToDouble(m) * 60) + Convert.ToDouble(s);
            }
        }

        // Ideally catches any injection attempts of data input not from the drop down menus 
        catch (System.FormatException g)
        {
            pts.InnerHtml = g.Message;
        }

        // The following variables contain the data that is directly used in the formulation of the Purdy Points

        // Velocity - This double stores the user's velocity as the Distance set given the event, divided by the time
        //  input by the user and converted to seconds as necessary for a Velocity: meters/seconds or m/sec
        double Velocity = (Distance / TotalTime);

        // Mnorm - This double functions as the variable used in the formula that equates to "M"; it is named as such
        //  due to the "M" in the equation having to be normalized, hence why the Velocity (The "Mark") is divided by
        //  the normalized factor "Pt1400"
        double Mnorm = Velocity / Pt1400;

        // Znorm - This double functions as the variable used in the formula that equates to "z"; it is named as such
        //  due to the "z" in the equation having to be normalized, hence why the Zero (Zero Offset) is divided by
        //  the normalized factor "Pt1400"
        double Znorm = Zero / Pt1400;

        // Pow - This double is strictly separated as its own variable in order to simplify the order of operations
        //  necessary to complete the full Purdy Point formula.  By separating the Math.Pow functionality, it was easier
        //  to read and understand the formula as a whole
        double Pow = Math.Pow(Math.E, C3 * (Mnorm - Znorm));

        // PurdyPts - This double encompasses the formulation that leads to finding the data for the table output given
        //  to the users.  This formula was the result of Dr. Purdy's dissertation and was "improved upon" by him from past
        //  works
        double PurdyPts = (C1 * (Mnorm - Znorm)) + (C2 * (Pow - 1));

        // This code is here in case user's would ever request to see their Purdy Points.
        //// pts.InnerHtml = "Purdy Points = " + PurdyPts;

        // Now that the Purdy Point has been found, preparations are made to contain the values that will be found for the
        //  other events

        // This double array is given a specific size of 15 in order to hold the Velocity Values for each event given a
        //  Purdy Point value.  
        double[] VelocityVals = new double[15];

        // The reason for j being set to 0 and the breakpoint being set to the length of ZerOff is for the for-loop
        //  to iterate through all the indexes of Zero Offsets, with the intent to find each Velocity, or Performance Mark,
        //  for the events
        for (int j = 0; j < ZeroOff.Length; j++)
        {
            // Vals - This list had to be a list rather than an array as each Zero Offset for a given event has a different
            //  amount of numbers between the Zero and Zero Offset and thus can not be initialized efficiently as a set size.
            List<double> Vals = new List<double>();

            // increment - the variable should be reset back to zero for each iteration through the loop
            double increment = 0;
  
            // This checks to see if the current Zero Offset the iteration is on is equal to Zero, aka, the initial, selected
            //  event the user chose.  If this is the case, then the event has already been given a velocity and the value at
            //  the current index of the VelocityVals should just be set as the Velocity from above.  Otherwise, a while loop is
            //  initiated....
            if (ZeroOff[j] == Zero)
            {
                VelocityVals[j] = Velocity;
            }
            else
            {
                // If initiated, a list of values that range from 0 to the Zero Offset of the event at the given index is created,
                //  with the double values present in the list increasing by 0.0001 every time, and being rounded to minimize the error
                //  that is marginal if controlled this way.
                while (increment < ZeroOff[j])
                {
                    Vals.Add(Math.Round(increment, 4));
                    increment += 0.0001;
                }

                // Once the list is created, it is then sent and used along with the Purdy Points and current index value to find
                //  the current event's velocity that would result in the formula generating the Purdy Point value
                VelocityVals[j] = LinearSearch(Vals, PurdyPts, j);
                
                // This line of code would be used instead if the BinarySearch function were fixed and able to be used
                ////VelocityVals[j] = BinarySearch(vals, PurdyPts, j);
            }
        }

        // This code sets the start of the html required to generate and display the output in a table to the user
        pts.InnerHtml = "<table>";

        // This string array is used in the for-loop below in order to display each value in each index in the proper
        //  area of the table.  It is formed using the valArrayVal function given the VelocityVals from the LinearSearch,
        //  the designated percentage performance marks (from and to) as well as the increment by which to increase the percentages
        string[] valArrayValues = valArrayVal(VelocityVals, PerfTo, PerfFrom, Increment);
        for (int i = 0; i < valArrayValues.Length; i++) {
            pts.InnerHtml += valArrayValues[i];
        }

        // This code marks the end of the html required to generate and display the output in a table to the user
        pts.InnerHtml += "</tr></table>";
    }

    // The purpose of this function is given a List of Velocity Values from 0 to the ZeroOffset, the found Purdy Points
    //  of a user, and an integer serving as the index of the above for-loop, to linearly try every number between the 
    //  Zero Offset of an event in the event array at index "j" and zero until the difference between the absolute value
    //  of the new Purdy Point value and original is between 0 and 1 (close to exact).  Whichever Velocity Value from the
    //  list is found to produce this result is then multiplied by the 1400 Point Level (reverse-normalize it) and returned
    //  as the appropriate event's Velocity, given its j index, for that Purdy Point level
    double LinearSearch(List<double> Vals, double PurdPts, int j)
    {
        // ValArray - This double array takes the list of Velocity Values applied to the function and converts it into an array,
        //  as it is now at the full size and will never need values added to it.
        double[] ValArray = Vals.ToArray();

        // NewPow - This double is created with the intent to store the value it is iteratively set to in the for-loop in the
        //  equation that will find the attempted New Purdy Point value
        // NewPurdy - This double is created with the intent to store the value it is iteratively set to in the for-loop to see
        //  the difference between itself and the original Purdy Point value.  The goal is to get the difference to be between
        //  0 and 1
        // Check - This double is created with the intent to store the absolute value of the difference between the original
        //  Purdy Point value found above and the new Purdy Point value found in this function
        double NewPow, NewPurdy, Check;

        // The reason for i being set to 0 and the breakpoint being set to the length of ValArray is for the for-loop
        //  to iterate through all the indexes of ValArray, with the intent to find the proper Purdy Point and therfore
        //  Velocity for the given event at index "j"
        for (int i = 0; i < ValArray.Length; i++)
        {
            NewPow = Math.Pow(Math.E, C3Arr[j] * (ValArray[i] - (ZeroOff[j]) / PtLvl1400[j]));
            NewPurdy = (C1Arr[j] * (ValArray[i] - (ZeroOff[j]) / PtLvl1400[j])) + (C2Arr[j] * (NewPow - 1));
            Check = Math.Abs(PurdPts - NewPurdy);
            if (Check > 0 && Check <= 1)
            {
                return ValArray[i] * PtLvl1400[j];
            }
        }

        // This would be the closest thing to the equivalent of the Zero Offset that could be returned if for some reason
        //  the loop was unable to find the Velocity
        return 0;
    }

    // The purpose of this function is given a double array of VelocityVals for each event, the percentage performance marks
    //  (PerfTo and PerfFrom), and the Increment by which to increase the percentages, to create a string that can be used as
    //  html to form the rows for the table that will be outputted to the user.  This is done by taking the Velocity values
    //  from VelocityVals and multiplying them by the current percentage performance mark (which is iterated through based on
    //  increment in a for-loop.).
    string[] valArrayVal(double[] VelocityVals, double PerfTo, double PerfFrom, double Increment)
    {
        // ValArrayVals - This string array allocates enough room to store enough html snippets to have the headers, including
        //  the distance event name and the Percentage Performance, as well as all the Velocity Values to be stored, with the
        //  addition of 1 space for the ending snippet with the closing html tags.
        string[] ValArrayVals = new string[VelocityVals.Length+1];

        // if the Percentage Performance given was inverted in the input, (e.g.: from 100% to 95%), then the user is alerted to
        //  switch the values.  If in the future a programmer wanted to implement a working way around this, then they would simply
        //  work backwards from the process below, and subtract iteratively rather than add 
        //  (i.e. PerfIter = Math.Round(PerfIter - Increment, 2); etc.)  This wasn't implemented as it suggests to the user that they
        //  hadn't made a mistake, even though they had.  This would probably be better to implement than the current code eventually.
        //  The function of the Percentage Performance would simply change from "from and to" into "1" and "2" with a function addition
        //  to find the greater of the two values 
        if (PerfTo < PerfFrom)
        {
            alert2.Style["display"] = "block";
            alert2.InnerHtml = "Please input your percentages from smallest to largest.";
        }

        // This is necessary to include to rehide the alert message when the user fixes the error
        else
        {
            alert2.Style["display"] = "none";
        }

        // ValArrayVal - This string is set to an empty string through each iteration of the for-loop in
        //  order to set each iteration as a new, fresh row of html snippets to put data in the table
        string ValArrayVal = "";

        // PerfIter - This double is set equal to the equivalent of the PerfFrom variable in order to
        // adjust the value without changing the PerfFrom value, as that is needed to stay constant
        double PerfIter = PerfFrom;

        // ValArryVals at index 0 is set to the following in order to ensure that the tables first row
        //  is created properly, and allows for the html snippets to continue through the first row in
        //  the upcoming while loop
        ValArrayVals[0] = "<tr><th>Distance</th>";

        // This while loop is simply making sure the header row has all the Percentage Performance Marks
        //  displayed over the Velocity Values that will be outputted to the user in the table
        while (PerfIter <= PerfTo)
        {
            ValArrayVals[0] += "<th>" + (PerfIter * 100) + "% Performance</th>";
            PerfIter = Math.Round(PerfIter + Increment, 2);
        }

        // TimeString - This string is initialized for future use in the for-loop to turn the Time into
        //  the proper format for the table
        string TimeString;

        // Time - This double is initiated for future use in the for-loop to simply give a variable to the
        //  Distance/Velocity
        double Time;

        

        // The purpose of this for-loop is to 
        for (int k = 0; k < VelocityVals.Length; k++)
        {
            ValArrayVal += "<tr><td>" + Events[k] + "</td>";

            // PerfCurr - This double acts almost identical to the "PerfIter" variable described above
            double PerfCurr = PerfFrom;

            // this while loop performs as long as the Percentage Performance hasn't reached the upper ceiling,
            //  the PerfTo variable's value, that was set by the user.  As the while loop runs, the Time is calculated,
            //  then immediately changed into a string for use in the html snippet to be used to create the table
            while (PerfCurr <= PerfTo)
            {

                // The scientific formula for Velocity is D/t or distance divided by time.  Based on basic algebra, time
                //  can be calculated by taking the distance of the event and dividing it by the Velocity, given the Velocity
                //  is diminished by the percentage of effort, aka, the Percentage Performance, (i.e. Velocity is multiplied
                //  by the Percentage Performance currently being used.)
                Time = DistanceArray[k] / (VelocityVals[k] * PerfCurr);

                // The following if/else statements check to see if the time input by the user is 1 of 3 things: an hour or more
                //  time used, less than an hour but more than 60 seconds used, or less than 60 seconds used.

                // If the time input was equal to or greater than an hour, then the time had to be converted from seconds into hour(s),
                // minute(s), and second(s).
                if (Time >= 3600)
                {
                    double hour = Math.Floor(Time / 3600);
                    double minute = Math.Floor((Time % 3600) / 60);
                    double second = Math.Round(Time - hour * 3600 - minute * 60, 3);
                    TimeString = hour + " hour " + minute + " min " + second + " sec";
                }

                // If the time input was less than an hour, but greater than 60 seconds, then the time had to be converted
                //  from seconds into minute(s), and second(s).
                else if (Time >= 60 && Time < 3600)
                {
                    double minute = Math.Floor(Time / 60);
                    double second = Math.Round(Time - minute * 60, 3);
                    TimeString = minute + " min " + second + " sec";
                }

                // If the time input was less than a minute, (60 seconds), then the time was simply rounded and set as the string
                else
                {
                    double second = Math.Round(Time, 3);
                    TimeString = second + " sec";
                }
                
                // Before the while loop goes through the next iteration, the PerfCurr variable must be updated and have the
                //  Percentage Performance it is represented be changed to the next Percentage up by the increment (e.g. if 
                //  PerfCurr = 0.80 and the user chose a 0.05 increment, then it is now set to 0.85 for the 85% Percentage Performance.)
                PerfCurr = Math.Round(PerfCurr + Increment, 2);
                ValArrayVal += "<td>" + TimeString + "</td>";
            }
            ValArrayVals[k+1] = ValArrayVal + "</tr></th></tr>";
            
            // A new, clean string is needed for the ValArrayVal variable to prevent large amounts of
            //  the table being repeated
            ValArrayVal = "";
        }
        return ValArrayVals;
    }

    //EOC, Thank you and we hope you enjoy using our program

    // NOTE: Some code below may have old versions of variable names and thus discretion should be taken if used

    // This would be much more efficient than the Linear Search if it could be figured out and is thus included 
    // in case someone were to improve upon the code in the future:

    ////double BinarySearch(List<double> Vals, double PurdPts, int j)
    ////{
    ////    ValArray = Vals.ToArray();
    ////    int Mini = 0;
    ////    int Max = ValArray.Length - 1;
    ////    while (Mini <= Max)
    ////    {
    ////        int mid = ((Mini + Max) / 2);
    ////        double NewPow = Math.Pow(Math.E, C3Arr[j] * (mid - (ZeroOff[j]) / PtLvl1400[j]));
    ////        double NewPurdy = (C1Arr[j] * (mid - (ZeroOff[j]) / PtLvl1400[j])) + (C2Arr[j] * (NewPow - 1));
    ////        if (Math.Round(PurdPts) == Math.Round(NewPurdy))
    ////        {
    ////            return ValArray[++mid];
    ////        }
    ////        else if (PurdPts < NewPurdy)
    ////        {
    ////            Max = mid - 1;
    ////        }
    ////        else
    ////        {
    ////            Mini = mid + 1;
    ////        }
    ////    }
    ////    return 0;
    ////}



    // The code below would allow for the "table" to be printed vertically rather than in a traditional horizontal table if
    // ever desired.

    ////string[] valArrayVal(double[] VelocityVals, double PerfTo, double PerfFrom, double Increment)
    ////{
    ////    if (PerfTo < PerfFrom)
    ////    {
    ////        alert2.Style["display"] = "block";
    ////        alert2.InnerHtml = "Please input your percentages from smallest to largest.";
    ////    }
    ////    else {
    ////        alert2.Style["display"] = "none";
    ////    }

    ////    string valArrayVal = "";
    ////    string timeString;
    ////    double time;
    ////    int u = 0;
    ////    double PerfCurr = PerfTo;
    ////    while (u < 20)
    ////    {
    ////        if(PerfCurr < PerfFrom)
    ////        {
    ////            break;
    ////        }
    ////        double[] VelocityValsN = new double[VelocityVals.Length];
    ////        for (int g = 0; g < VelocityVals.Length; g++)
    ////        {
    ////            VelocityValsN[g] = VelocityVals[g] * PerfCurr;
    ////        }

    ////        for (int k = 0; k < Events.Length; k++)
    ////        {
    ////            time = DistanceArray[k] / VelocityValsN[k];
    ////            if (time >= 3600)
    ////            {
    ////                double hour = Math.Floor(time / 3600);
    ////                double minute = Math.Floor((time % 3600) / 60);
    ////                double second = Math.Round(time - hour * 3600 - minute * 60, 3);
    ////                timeString = hour + " hour " + minute + " min " + second + " sec";
    ////            }
    ////            else if (time >= 60 && time < 3600)
    ////            {
    ////                double minute = Math.Floor(time / 60);
    ////                double second = Math.Round(time - minute * 60, 3);
    ////                timeString = minute + " min " + second + " sec";
    ////            }
    ////            else
    ////            {
    ////                double second = Math.Round(time, 3);
    ////                timeString = second + " sec";
    ////            }
    ////            valArrayVal +=  "<tr><td>" + Events[k] + "</td>" + "<td>" + timeString + "</td></tr>";
    ////        }
    ////        ValArrayVals[u] = "<tr><th>Distance</th><th>" + (PerfCurr*100) + "% Performance</th></tr>"+ valArrayVal + "</th></tr>";
    ////        PerfCurr = Math.Round(PerfCurr - Increment, 2);
    ////        valArrayVal = "";
    ////        u += 1;
    ////    }
    ////return ValArrayVals;
    ////}
}
