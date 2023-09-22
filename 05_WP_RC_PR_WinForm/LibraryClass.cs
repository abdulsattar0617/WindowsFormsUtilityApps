using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Design;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _05_WP_RC_PR_WinForm
{
    // Customer class 
    public class Customer
    {
        
        
        // GENERATE RANDOME NUMBER -FOR CUSTOEMR NUMBER
        public string customerNumber;

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; } 

        public string Email { get; set; }   


        public string genRandomNumber()
        {
            // Create a random number generator
            Random random = new Random();

            // Define the length of the string
            int length = 10;

            // Create a StringBuilder to build the random string
            StringBuilder stringBuilder = new StringBuilder(length);

            // Generate and append random digits to the string
            for (int i = 0; i < length; i++)
            {
                int randomDigit = random.Next(10); // Generates a random number between 0 and 9
                char digitChar = (char)('0' + randomDigit); // Convert the random number to a character
                stringBuilder.Append(digitChar); // Append the character to the string
            }

            // Convert the StringBuilder to a string
            string randomString = stringBuilder.ToString();


            // Return the generated random string 
            
            return randomString; 
        }

        public void genCustomerNumber()
        {
            this.customerNumber = this.genRandomNumber(); 
        }


        public void setCustomer()
        {
            // 1. generate customer number
            this.genCustomerNumber(); 

            // 2. 
        }
    }

    // Billing class
    public class Billing
    {
        // 


        // FIXED CHARGES
        public decimal FixedCharges = 126.00m;  

        // ENERGY CHARGES
        public decimal EnergyCharges;

        // CONSUMED UNIT
        public double ConsumedUnit; 

        // WHEELING CHARGES
        public decimal WheelingCharges;

        // F.A.C CHARGES
        public decimal FAC_Charges = 4.13m;

        // ELECTRICITY DUTY
        public decimal ElectricityDuty = 0;

        // TAX ON SCALE 
        public decimal Tax_On_Scale = 4.79m;

        // CURRENT INTEREST
        public decimal CurrentInterest = 0;

        // TOTAL BILL
        public decimal TotalBill = 0;  

        // METHOD : CALCULATE ELECTRICITY DUTY
        private void calc_ElectricityDuty()
        {
            decimal duty_charge = 0.16m;  // 16%   

            this.ElectricityDuty = Convert.ToDecimal((this.FixedCharges + this.EnergyCharges + this.WheelingCharges) * duty_charge);   
        }

        // METHOD : CALCULATE WHEELING CHARGS
        private void calc_WheelingCharges()
        {
            double perUnitCharge = 1.17; 

            this.WheelingCharges = Convert.ToDecimal(this.ConsumedUnit * perUnitCharge);  
        }

        // METHOD : CALCULATE ENERGY CHARGS
        private void calc_EnergyCharges()
        {
            double unitCharge;
            
            if (this.ConsumedUnit  == 0) 
            {
                this.EnergyCharges = 0; 
                return; 
            }
            else if (this.ConsumedUnit > 0 && this.ConsumedUnit <= 100)
            {
                unitCharge = 4.41;
                this.EnergyCharges = Convert.ToDecimal(this.ConsumedUnit * unitCharge);  
            }
            else if (this.ConsumedUnit > 100 && this.ConsumedUnit <= 300)
            {
                unitCharge = 9.64;
                // + upto 100 
                this.EnergyCharges = 441.00m + Convert.ToDecimal((this.ConsumedUnit - 100) * unitCharge);  
            }
            else if (this.ConsumedUnit > 300 && this.ConsumedUnit <= 500)
            {
                unitCharge = 13.61;
                // + upto 300
                this.EnergyCharges = 441m + 1928m + Convert.ToDecimal((this.ConsumedUnit - 300) * unitCharge); 
            }
            else if (this.ConsumedUnit > 500 && this.ConsumedUnit <= 1000)
            {
                unitCharge = 15.57;

                // + upto 500
                this.EnergyCharges =  441m + 1928m + 2722m + Convert.ToDecimal((this.ConsumedUnit - 500) * unitCharge);               
            }
            else
            {
                unitCharge = 15.57;

                // + upto 1000 
                this.EnergyCharges = 441m + 1928m + 2722m + 7785m + Convert.ToDecimal((this.ConsumedUnit - 1000) * unitCharge);  
                
            }

        }
       
        // METHOD : CALCULATE TOTAL BILL
        public void calc_TotalBill()
        {
            this.TotalBill = 0; 

            // 1. CALCULATE ENERGY CHARGES
            this.calc_EnergyCharges();

            // 2. CALCULATE WHEELING CHARGES
            this.calc_WheelingCharges();

            // 3. CALCULATE ELECTRICITY DUTY
            this.calc_ElectricityDuty();

            // 4. TOTAL BILL

            // ADD FIXED CHARGES
            this.TotalBill += this.FixedCharges;
            // ADD ENERGY CHARGES
            this.TotalBill += this.EnergyCharges;
            // ADD WHEELING CHARGES
            this.TotalBill += this.WheelingCharges;
            // ADD ELECTRICTY DUTY
            this.TotalBill += this.ElectricityDuty;

            // ADD TAX ON SCALE
            this.TotalBill += this.Tax_On_Scale;
            // ADD F.A.C CHARGES
            this.TotalBill += this.FAC_Charges; 
            // ADD CURRENT INTEREST
            this.TotalBill += this.CurrentInterest; 

            this.TotalBill = Math.Round(TotalBill, 2); 
        }


    }


    // Bill class 
    public class Bill
    {
        // CUSTOMER DETAIL
        public Customer customer = new Customer();

        // BILL DETAIL
        public Billing billing = new Billing();

        // PREVIOUS BILLS STRING
        public string[] PreviousBillList; 

        // APP SYSTEM FILES PATH 
        private string APP_SYS_FILE_PATH = "C:\\MSEB\\System Files\\";

        // PREVIOUS BILL FILE PATH 
        private string PREVIOUS_BILL_FILE_PATH = "PREVIOUS_BILL.txt";

        // BILL FILE PATH
        private string BILL_FILE_PATH;

        // BILL CALCULATED FLAG
        private bool BILL_CALCULATED = false; 

        // CURRENT READING DATE 
        public string CURRENT_READING_DATE;

        // PREVIOUS READING DATE 
        public string PREVIOUS_READING_DATE;

        // BILL SUPPLY DATE 
        public string BILL_SUPPLY_DATE;

        // HSN CODE
        public string HSN_CODE;

        // SANCTIONED LOAD 
        public double SANC_LOAD;

        // METER NUMBER
        public string METER_NUMBER; 

        // READING GROUP
        public string READING_GROUP = "H2";

        // BILL PERIOD
        public double BILL_PERIOD = 1;

        // METER STATUS 
        public string METER_STATUS = "Normal";

        // CATEGORY
        public string CATEGORY = "090/LT I Res 1-Phase";

        // POLL NUMBER
        public string POLL_NUMBER;

        // SECURTIY DEPOSIT
        public decimal SECURITY_DEPOSIT = 1000m;    

        // SUPPLY DATE 
        public string METER_SUPPLY_DATE;  

        // BILLING UNIT
        public string Billing_Unit = "2313/PARBHANI (U) S/D/PARBHANI-I";  

        // BILL DATE = TODAY DATE
        public string BILL_DATE;

        // BILL DUE DATE  = TODAY DATE + 15 DAYS
        public string BILL_DUE_DATE;

        // DUE CHARGES
        public decimal DUE_CHARGES = 10m;

        // PREVIOUS READING 
        public string previousReading;

        // CURRENT READING
        public string currentReading;


        
        

        // BILL NUMBER

        // Generate a random number with 6 digits
        public string billNumber;   
        
        // METHOD : GENERATE HSN CODE
        public void genHSN_Code()
        {
            this.HSN_CODE = this.customer.genRandomNumber(); 
        }
        
        // METHOD : GENERATE METER NUMBER
        public void genMeterNumber()
        {
            this.METER_NUMBER = this.customer.genRandomNumber(); 
        }

        // METHOD : CALCULATE DATES
        public void calculateDates()
        {
            DateTime currentDate = DateTime.Now;

            // BILL SUPPLY DATE 
            this.BILL_SUPPLY_DATE = currentDate.ToString("MMM yyyy").ToUpper();  
            
            // METER SUPPLY DATE 
            this.METER_SUPPLY_DATE = "01-01-2023"; 

            // BILL DATE 
            this.BILL_DATE = currentDate.ToString("dd MM yyyy"); 

            // BILL DUE DATE 
            this.BILL_DUE_DATE = currentDate.AddDays(15).ToString("dd MM yyyy");

            // CURRENT READING DATE 
            this.CURRENT_READING_DATE = currentDate.ToString("dd MM yyyy");

            // PREVIOUS READING DATE 
            this.PREVIOUS_READING_DATE = currentDate.AddDays(-30).ToString("dd MM yyyy"); 

        }
        public void calculateReadings()
        {
            this.previousReading = (Convert.ToDouble(this.currentReading) - this.billing.ConsumedUnit).ToString();  
        }

        

        // METHOD : GENERATE BILL NUMBER
        public void genBillNumber()
        {            
            this.billNumber = this.customer.genRandomNumber();
        }


        // METHOD : CALCULATE BILL
        public void calculateBill()
        {
            // 1. CUSTOMER DETAILS
            this.customer.setCustomer();

            // 2. BILL SUPPLY DATE 
            // 3. METER SUPPLY DATE 
            // 4. BILL DATE 
            // 5. BILL DUE DATE 
            // 6. CURRENT READING DATE 
            // 7. PREVIOUS READING DATE 
            this.calculateDates();

            // 8. BILL NUMBER
            this.genBillNumber();

            // 9. HSN CODE 
            this.genHSN_Code();

            // 10. BILLING UNIT (such as area)
            this.Billing_Unit = "2313/PARBHANI (U) S/D/PARBHANI-I";

            // 11. CATEGORY 
            this.CATEGORY = "090/LT I Res 1-Phase";

            // 12. Poll Number
            this.POLL_NUMBER = "0000";

            // 13. SANCTIONED LOAD 
            this.SANC_LOAD = 0.50;

            // 14. METER NUMBER
            this.genMeterNumber();

            // 15. METER STATUS
            this.METER_STATUS = "Normal";

            // 16. BILL PERIOD 
            this.BILL_PERIOD = 1;


            // 17. CURRENT READING
            // 18. PREVIOUS READING
            this.calculateReadings();

            // 19. CONSUMED UNIT

            // 20. SECURITY DEPOSIT
            this.SECURITY_DEPOSIT = 1000;

            // 21. BILL AMOUNT
            this.billing.calc_TotalBill();

            // SET  BILL CALCULATED
            this.BILL_CALCULATED = true; 
        }

        private int countFileLine(string filePath)
        {
            try
            {
                int lineCount = 0;

                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }

                // Console.WriteLine("Number of lines in the file: " + lineCount);

                return lineCount;
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
            return 0;
        }

        public bool readPreviousBillFile()
        {
            string filePath = this.APP_SYS_FILE_PATH + this.PREVIOUS_BILL_FILE_PATH;
            if (File.Exists(filePath))
            {
                try
                {
                    int fileSize = this.countFileLine(filePath);
                    this.PreviousBillList = new string[fileSize]; 

                    using (StreamReader fileReader = new StreamReader(filePath))
                    {
                        string line;
                        int index = 0;
                        while ((line = fileReader.ReadLine()) != null)
                        {
                            this.PreviousBillList[index++] = line.Trim(); 
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
            }
            return false;
        }

        private bool lineExist(string filePath, string searchLine)
        {
            try
            {
                // Open the file for reading
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Compare the current line with the line you're searching for
                        if (line == searchLine)
                        {
                            return true;

                        }
                    }
                }
                return false;
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
                return false;
            }
        }

        private bool updatePreviousBillFile()
        {
            if (this.BILL_CALCULATED)
            {
                try
                {
                    // IF DIR DOES NOT EXIST
                    if (!Directory.Exists(this.APP_SYS_FILE_PATH))
                    {
                        Directory.CreateDirectory(this.APP_SYS_FILE_PATH); 
                    }
                    
                    // 1. update previous bill file
                    string filePath = this.APP_SYS_FILE_PATH + this.PREVIOUS_BILL_FILE_PATH;

                    using (StreamWriter fileWriter = new StreamWriter(filePath, true))
                    {
                        string line = string.Empty;

                        line = this.billNumber.Trim();

                        if (!lineExist(filePath, line))
                        {
                            fileWriter.WriteLine(line); 
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Some error occured : " + e.Message);
                }

            }

            return false;
        }

        private bool saveBill()
        {
            if (this.BILL_CALCULATED)
            {
                try
                {
                    // IF DIR DOES NOT EXIST
                    if (!Directory.Exists(this.APP_SYS_FILE_PATH))
                    {
                        Directory.CreateDirectory(this.APP_SYS_FILE_PATH);
                    }

                    // 1. store current bill 
                    this.BILL_FILE_PATH = this.billNumber + ".txt"; 

                    string filePath = this.APP_SYS_FILE_PATH + this.BILL_FILE_PATH;  

                    using (StreamWriter fileWriter = new StreamWriter(filePath, true))
                    {
                        string line = string.Empty;

                        // 1. Customer
                        // CUSTOMER NUMBER, NAME, PHONE, EMAIL
                        line = this.customer.customerNumber.Trim() + "," +
                                this.customer.Name.Trim() + "," +
                                this.customer.PhoneNumber.Trim() + "," +
                                this.customer.Email.Trim();   

                        fileWriter.WriteLine(line);

                        // 2. ADDRESS
                        line = this.customer.Address.Trim();

                        fileWriter.WriteLine(line);

                        // 3. Billing
                        // FIXED CHARGES, ENERGY CHARGES, CONSUMED UNITS, WHEELING CHARGES, FAC CHARGES, ELECTRICITY DUTY, TAX ON SCALE, CURRENT INTEREST, TOTAL BILL
                        line = this.billing.FixedCharges + "," +
                                this.billing.EnergyCharges + "," +
                                this.billing.ConsumedUnit + "," +
                                this.billing.WheelingCharges + "," +
                                this.billing.FAC_Charges + "," +
                                this.billing.ElectricityDuty + "," +
                                this.billing.Tax_On_Scale + "," +
                                this.billing.CurrentInterest + "," +
                                this.billing.TotalBill; 

                        fileWriter.WriteLine(line);

                        // 4. CURRENT READING DATE
                        line = this.CURRENT_READING_DATE;

                        fileWriter.WriteLine(line);

                        // 5. PREVIOUS READING DATE 
                        line = this.PREVIOUS_READING_DATE;

                        fileWriter.WriteLine(line);

                        // 6. Bill Supply Date
                        line = this.BILL_SUPPLY_DATE;

                        fileWriter.WriteLine(line);

                        // 7. HSN Code
                        line = this.HSN_CODE;

                        fileWriter.WriteLine(line);

                        // 8. Sanc Load
                        line = this.SANC_LOAD.ToString();

                        fileWriter.WriteLine(line);

                        // 9. METER Number
                        line = this.METER_NUMBER;

                        fileWriter.WriteLine(line);

                        // 10. Reading Group
                        line = this.READING_GROUP; 

                        fileWriter.WriteLine(line);

                        // 11. bill period
                        line = this.BILL_PERIOD.ToString(); 

                        fileWriter.WriteLine(line);

                        // 12. Meter Status
                        line = this.METER_STATUS;

                        fileWriter.WriteLine(line);

                        // 13. Category
                        line = this.CATEGORY;

                        fileWriter.WriteLine(line);

                        // 14. Poll Number
                        line = this.POLL_NUMBER;

                        fileWriter.WriteLine(line);

                        // 15. Security Deposit
                        line = this.SECURITY_DEPOSIT.ToString();

                        fileWriter.WriteLine(line);

                        // 16. Meter supply date
                        line = this.METER_SUPPLY_DATE;

                        fileWriter.WriteLine(line);

                        // 17. billing Unit
                        line = this.Billing_Unit;

                        fileWriter.WriteLine(line);

                        // 18. bill date
                        line = this.BILL_DATE;

                        fileWriter.WriteLine(line);

                        // 19. bill due date
                        line = this.BILL_DUE_DATE;

                        fileWriter.WriteLine(line);

                        // 20. due charges
                        line = this.DUE_CHARGES.ToString();

                        fileWriter.WriteLine(line);

                        // 21. previous reading
                        line = this.previousReading;

                        fileWriter.WriteLine(line);

                        // 22. currentReading
                        line = this.currentReading;

                        fileWriter.WriteLine(line);

                        // 23. Bill Number
                        line = this.billNumber;

                        fileWriter.WriteLine(line);

                        // 
                        return true; 
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Some error occured : " + e.Message);
                }

            }

            return false;
        }

        public bool saveBillInFile()
        {
            if (this.BILL_CALCULATED)
            {
                try
                {
                    // 1. update previous bill file
                    updatePreviousBillFile();


                    // 2. store current bill 
                    saveBill(); 
                }
                catch (Exception e) 
                {
                    Console.WriteLine("Some error occured : " + e.Message); 
                }

            }

            return false; 
        }

        public bool readBillFile(string fileName)
        {
            // IF EXTENSION NOT INCLUDED 
            if (!fileName.EndsWith(".txt"))
            {
                fileName = fileName + ".txt";
            }

            string filePath = this.APP_SYS_FILE_PATH + fileName; 
            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader fileReader = new StreamReader(filePath))
                    {
                        string line = string.Empty;
                        string[] values;
                        int index = 0; 

                        // 1. Customer 
                        // CUSTOMER NUMBER, NAME, PHONE, EMAIL
                        line = fileReader.ReadLine();
                        values = new string[4]; 
                        index = 0;


                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        this.customer.customerNumber = values[0];
                        this.customer.Name = values[1];
                        this.customer.PhoneNumber = values[2];
                        this.customer.Email = values[3];

                        // 2. Address 
                        line = fileReader.ReadLine() ;

                        this.customer.Address = line.Trim();


                        // 3. Billing 
                        // FIXED CHARGES, ENERGY CHARGES, CONSUMED UNITS, WHEELING CHARGES, FAC CHARGES, ELECTRICITY DUTY, TAX ON SCALE, CURRENT INTEREST, TOTAL BILL
                        line = fileReader.ReadLine();
                        values = new string[9]; 
                        index = 0;


                        foreach (string val in line.Split(','))
                        {
                            if (val != "")
                            {
                                values[index++] = val;
                            }
                        }

                        // SET VALUES
                        this.billing.FixedCharges = Convert.ToDecimal(values[0]);
                        this.billing.EnergyCharges = Convert.ToDecimal(values[1]);
                        this.billing.ConsumedUnit = Convert.ToDouble(values[2]);
                        this.billing.WheelingCharges = Convert.ToDecimal(values[3]);
                        this.billing.FAC_Charges = Convert.ToDecimal(values[4]);
                        this.billing.ElectricityDuty = Convert.ToDecimal(values[5]);
                        this.billing.Tax_On_Scale = Convert.ToDecimal(values[6]);
                        this.billing.CurrentInterest = Convert.ToDecimal(values[7]);
                        this.billing.TotalBill = Convert.ToDecimal(values[8]);

                        // 4. Currrent Reading Date
                        line = fileReader.ReadLine();

                        this.CURRENT_READING_DATE = line.Trim();

                        // 5. Previous Reading Date
                        line = fileReader.ReadLine();

                        this.PREVIOUS_READING_DATE = line.Trim();

                        // 6. Bill Supply Date
                        line = fileReader.ReadLine();

                        this.BILL_SUPPLY_DATE = line.Trim();

                        // 7. HSN Code
                        line = fileReader.ReadLine();

                        this.HSN_CODE = line.Trim();

                        // 8. Sanc Load
                        line = fileReader.ReadLine();

                        this.SANC_LOAD = Convert.ToDouble(line.Trim());

                        // 9. METER Number
                        line = fileReader.ReadLine();

                        this.METER_NUMBER = line.Trim();

                        // 10. Reading Group
                        line = fileReader.ReadLine();

                        this.READING_GROUP = line.Trim();

                        // 11. bill period
                        line = fileReader.ReadLine();

                        this.BILL_PERIOD = Convert.ToDouble(line.Trim());

                        // 12. Meter Status
                        line = fileReader.ReadLine();

                        this.METER_STATUS = line.Trim();

                        // 13. Category
                        line = fileReader.ReadLine();

                        this.CATEGORY = line.Trim();

                        // 14. Poll Number
                        line = fileReader.ReadLine();

                        this.POLL_NUMBER = line.Trim();

                        // 15. Security Deposit
                        line = fileReader.ReadLine();

                        this.SECURITY_DEPOSIT = Convert.ToDecimal(line.Trim());

                        // 16. Meter supply date
                        line = fileReader.ReadLine();

                        this.METER_SUPPLY_DATE = line.Trim();

                        // 17. billing Unit
                        line = fileReader.ReadLine();

                        this.Billing_Unit = line.Trim();

                        // 18. bill date
                        line = fileReader.ReadLine();

                        this.BILL_DATE = line.Trim();

                        // 19. bill due date
                        line = fileReader.ReadLine();

                        this.BILL_DUE_DATE = line.Trim();

                        // 20. due charges
                        line = fileReader.ReadLine();

                        this.DUE_CHARGES = Convert.ToDecimal(line.Trim());

                        // 21. previous reading
                        line = fileReader.ReadLine();

                        this.previousReading = line.Trim();

                        // 22. currentReading
                        line = fileReader.ReadLine();

                        this.currentReading = line.Trim();

                        // 23. Bill Number
                        line = fileReader.ReadLine();

                        this.billNumber = line.Trim();


                        return true; 
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);

                    return false; 
                }
            }
            return false;
        }





        // --------------- STATIC INSTANCE ------------------
        private static Bill instance; 

        private Bill() { }

        public static Bill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bill(); 
                }
                return instance;
            }
        }
        // ---------------------------------------------------
    }
    // internal class LibraryClass
    // {
    // }
}




