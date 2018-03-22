using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agilent.Agilent66xx.Interop;
//using Ivi.DCPwr.Interop;
//using Ivi.Driver.Interop;

namespace dcascontroller
{
    class powerSupplyController
    {

        Agilent66xx driver;      
        string error = "";
        string connInfo = "";
        double maxAllowedCurr = 874;
        double maxAllowedVolt = 4.99;
        public bool systemstatus { get; set; }

        private long initializeDriver(string resourceDesc)
        {
            try
            {

                //output basic driver information
                connInfo = connInfo + "Identifier:" + driver.Identity.Identifier + "\n";
                connInfo = connInfo + "Revision: " + driver.Identity.Revision + "\n";
                connInfo = connInfo + "Vendor: " + driver.Identity.Vendor + "\n";
                connInfo = connInfo + "Description:" + driver.Identity.Description + "\n";

                // Setup VISA resource descriptor - how the driver will connect to the power supply.

                //Examples of other valid VISA resource descriptors
                //"TCPIP::MPE12345678::50505::SOCKET";   //NETBIOS name direct to TCP port
                //"TCPIP::MPE12345678::inst0::INSTR";    //NETBIOS name to VXI (via UDP and TCP port 111)
                //"TCPIP::192.168.1.100::50505::SOCKET"; //IP address direct to TCP port
                //"GPIB0::13::INSTR";                    //GPIB address 13
                //"ASRL1";                               //COM Port 1


                //string resourceDesc = "ASRL3";
                // resourceDesc = "GPIB0::22::INSTR";

                // Setup IVI-defined initialization options
                //string standardInitOptions =
                  //  "Cache=true, InterchangeCheck=false, QueryInstrStatus=true, RangeCheck=true, RecordCoercions=false, Simulate=false";

                // Setup driver-specific initialization options
                //string driverSetupOptions =
                 //   "DriverSetup= Model=MPEIVI, Trace=false";

                Console.WriteLine("Connecting to Power Supply...");
                driver.Initialize(resourceDesc, true, true, "");
                return 1;
            }
            catch (Exception ex)
            {
                error = error + "Error initializing driver." + "\n";
                error = error + "Ensure resource descriptor is correct and power supply is on." + "\n";
                error = error + "Exception Message:" + ex.Message + "\n";
                return 0;
            }
            finally
            {
                connInfo += "Initialization Completed\n";
            }
        }
        public powerSupplyController()//default constructor
        {
            string resourceDesc = "GPIB0::22::INSTR";

            try
            {
                driver = null;
                try
                {
                    driver = new Agilent66xx();
                    initializeDriver(resourceDesc);
                }
                catch (Exception ex)
                {
                    error = error + "Error creating driver object.  Ensure IVI driver is installed.";
                    error = error + "Exception Details: " + ex.ToString();
                    return;
                }
            }
            catch (Exception ex)
            {
                error = error + "Error creating driver object.  Ensure IVI driver is installed.";
                error = error + "Exception Details: " + ex.ToString();
                return;

            }
        }
        public powerSupplyController(int psAddressIndx)//default constructor
        {
            string resourceDesc;
            try
            {
                driver = null;
                try
                {
                    driver = new Agilent66xx();
                    switch (psAddressIndx)
                    {
                        case 0:
                            resourceDesc = "ASRL3";
                            break;
                        case 1:
                            resourceDesc = "ASRL1";
                            break;
                        case 2:
                            resourceDesc = "GPIB0::22::INST";
                            break;
                        case 3:
                            resourceDesc = "GPIB1";
                            break;                        
                        default:
                            resourceDesc = "ASRL3";
                            break;
                    }
                    initializeDriver(resourceDesc);
                }
                catch (Exception ex)
                {
                    error = error + "Error creating driver object.  Ensure IVI driver is installed.";
                    error = error + "Exception Details: " + ex.ToString();
                    return;
                }
            }
            catch (Exception ex)
            {
                error = error + "Error creating driver object.  Ensure IVI driver is installed.";
                error = error + "Exception Details: " + ex.ToString();
                return;

            }  
        }
        public String checkConnection()
        {
            string returnValue="Check Results:\n";
            try
            {


                //Retrieve the name of the only output of the power supply
                //string outputName = driver.Outputs.get_Name(1);

                //There are two interfaces for accessing the power supply
                //IIviDCPwrOutput and IMPEIVIOutput.
                //
                //The IVI DCPwr interface can be used to access all of the standard IVI-defined functions
                //The MPE interface allows access to the full functionality of the power supply.

               // mpeOutput = driver.Output. Outputs.get_Item(outputName) as IMPEIVIOutput;
                //iviOutput = mpeOutput;
                systemstatus = true;
                returnValue = returnValue + "Making sure Power supply is in remote mode.\n";
                /*systemstatus=driver.Output.QueryState(Agilent66xxOutputStateEnum.Agilent66xxOutputUnregulated);
                if (systemstatus)
                returnValue = returnValue + "Power Supply is in Unregulated State \n";*/
               // MPEIVISetpointEnum origSetPoint = mpeOutput.Setpoint;

                //Make sure the power supply is off
               

                //Ensure the setpoint is Remote
               // mpeOutput.Setpoint = MPEIVISetpointEnum.MPEIVISetpointRemote;


                
                //Retrieve the IDN string
                
               
            }
            catch (Exception ex)
            {
                systemstatus = false;
                returnValue = returnValue + "Voltage or couldn't be set\n"+ex.ToString();
                
            }
             finally {
                 returnValue=returnValue+"You can continue\n";
                 
             }

               


            return returnValue;
        
        
    }
        public string getError()
        {
            return error;
        }
        public string getConnInfo()
        {
            return connInfo;
        }
        public IAgilent66xxOutput getOutputHandler(powerSupplyController pSC)
        {
            return pSC.driver.Output ;
        }

        public IAgilent66xxOutput getIMPEOutput(powerSupplyController pSC)
        {
            return pSC.driver.Output;
        }
       /* public IMPEIVIOutput getIMPEOutput(powerSupplyController pSC)
        {
            
            return pSC.mpeOutput;
        }*/
        /*public void disable()
        {
            (driver as IIviDriverUtility).Disable();
        }*/
        public double getcurrentMeasurement()
        {

            return driver.Output.Measure(Agilent66xxMeasurementTypeEnum.Agilent66xxMeasurementCurrent);
        }
        public double getvoltageMeasurement()
        {

            return driver.Output.Measure(Agilent66xxMeasurementTypeEnum.Agilent66xxMeasurementVoltage);
        }
    }
}
