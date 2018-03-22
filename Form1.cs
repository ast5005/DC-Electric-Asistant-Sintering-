using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NationalInstruments.DAQmx;
using NationalInstruments;
using System.Windows.Forms.DataVisualization.Charting;



namespace dcascontroller
{
    public partial class Form1 : Form
    {
        powerSupplyController pSC1;

        //init parameterholders
       String cache="true";
        String InterchangeCheck="false";
        String QueryInstrStatus="True";
        
        String RangeCheck="true"; 
        String RecordCoercions="false"; 
        String Simulate="0";          
        String DriverSetup="";
        String Model = "MPEIVI";
        String Trace="false";
        double voltage = 1.0;
        double current = 1.0;
        int time = 1;
        bool stopsignal = true;
        bool autostopsignal = true;
        bool treading = false;
        BackgroundWorker bgw;
        BackgroundWorker bgwauto;
        int n = 0;//temp
        int timer = 0;
        double autotimer = 0;
        double totaltimer = 0;
        int tempaveraging = 3;
        int coolingtime = 0;
        //double autoincreaserate = 10;
        //double autodecreaserate = 10;
        bool loopbreak = true;
        bool autoloopbreak = true;
        double minimumValueNumeric=0;
        double maximumValueNumeric=1000;
        double cjcValueNumeric=25;
        double rateNumeric=5;//Hz
        String approachlabeltext = "";
        private AnalogMultiChannelReader analogInReader;
        private AsyncCallback myAsyncCallback;
        private Task myTask;
        private Task runningTask;
        private AnalogWaveform<double>[] data;
        private DataColumn[] dataColumn = null;
        private DataTable dataTable = null;
        private List<double> tempData;
        private List<ctData> ctprog;
        double currentauto = 0;
        double currentmax = 0;
        double kp = 0;
        double ki = 0;
        double kd = 0;
        double setpoint = 0;
        int iterator = 0;
        double autoduration;
        double approacher = 0;
        System.IO.FileStream fs;
        bool fileopened = false;
        System.IO.StreamWriter fs_writer;
        bool contcoolingcheck = true;
        double resistance;
        double preapproacher;
        double derivative;
        double integral;
        double temp = 0;
        /*"Cache=true, InterchangeCheck=false, QueryInstrStatus=true, RangeCheck=true, RecordCoercions=false, Simulate=false";

                    // Setup driver-specific initialization options
                    string driverSetupOptions =
                        "DriverSetup= Model=MPEIVI, Trace=false";

         * 
         */

        public Form1()
        {
            InitializeComponent();            
            //init psaddress combobox
            this.psAddress.Items.Add("ASRL3::INSTR");
            this.psAddress.Items.Add("GPIB0::22::INSTR");
            bgw = new BackgroundWorker();
            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_progressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_runworkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.WorkerSupportsCancellation = true;

            bgwauto = new BackgroundWorker();
            bgwauto.DoWork += new DoWorkEventHandler(bgwauto_DoWork);
            bgwauto.ProgressChanged += new ProgressChangedEventHandler(bgwauto_progressChanged);
            bgwauto.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwauto_runworkerCompleted);
            bgwauto.WorkerReportsProgress = true;
            bgwauto.WorkerSupportsCancellation = true;
            label11.Enabled = false;
            label10.Enabled = false;
            //cjcSourceComboBox.SelectedIndex = 1;
            //autoZeroModeComboBox.SelectedIndex = 0;
            thermocoupleTypeSelector.SelectedIndex = 3;
            myAsyncCallback = new AsyncCallback(AnalogInCallback);
            dataTable = new DataTable();
            tempData = new List<double>();
            ctprog=new List<ctData>();
            tempReaderChannel.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
            if (tempReaderChannel.Items.Count > 0)
                tempReaderChannel.SelectedIndex = 0;
           /* chart1.Series.Add("Temperature");
            chart1.Series["Temperature"].ChartType = SeriesChartType.Line;
            chart1.Series["Temperature"].ChartArea = "ChartArea1";
            chart1.Series.Add("Current");
            chart1.Series["Current"].ChartType = SeriesChartType.Line;
            chart1.Series["Current"].ChartArea = "ChartArea1";
            chart1.Series.Add("Setpoint");
            chart1.Series["Setpoint"].ChartType = SeriesChartType.Line;
            chart1.Series["Setpoint"].ChartArea = "ChartArea1";*/
           



            
        }
        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;              
                pSC1.getOutputHandler(pSC1).VoltageLevel = voltage;
                pSC1.getOutputHandler(pSC1).CurrentLimit = current;
                pSC1.getOutputHandler(pSC1).Enabled = true;
                while (loopbreak)
                {
                    //MessageBox.Show("while in icinde", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("for in icinde i=" + i, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    System.Threading.Thread.Sleep(1000);
                    worker.ReportProgress(0);
                      
                    if ((worker.CancellationPending == true)) break;
                    if (timer < n + 1)
                    {
                        loopbreak = true;                        
                    }
                    else { loopbreak = false; }
                    
                    timer++;
                }
                pSC1.getOutputHandler(pSC1).Enabled = false;
                
            }

            catch (Exception ex1)
            {
                MessageBox.Show("Manual Start  Button Exception occured :\n" + ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           

        }
        private void bgwauto_DoWork(object sender, DoWorkEventArgs e)
        {
            double voltageauto = 5;
            double currentlimit = 0;
            //int autotimer = 0;
            try
            {
                ctData cttest = ctprog.Last<ctData>();
               // MessageBox.Show("Current Auto" + cttest.maximumCurr);
                BackgroundWorker worker = sender as BackgroundWorker;
                if (fileopened)
                    fs_writer.WriteLine("TIME,   CURRENT, VOLTAGE,   TEMPERATURE, SETPOINT, PREAPPROACHER, APPROACHER, INTEGRAL, DERIVATIVE , PROGRAM NO, MAX. CURRENT,PROG. DURATION");
                foreach (ctData ctprog1 in this.ctprog)
                {
                    
                    autoloopbreak = true;
                   
                    
                    derivative = 0;
                    integral=0;
                    
                    preapproacher = ctprog1.temperature;
                    currentmax = ctprog1.maximumCurr;
                    double currentmin=ctprog1.minimumCurr;
                    currentlimit = currentmax;
                    setpoint = ctprog1.temperature;
                    autoduration=ctprog1.duration;
                    autotimer = 0;
                   
                    currentauto = (currentmax + currentmin) / 3;
                    //MessageBox.Show("burda" + currentauto);
                    derivative = 0;
                    //pSC1.getOutputHandler(pSC1).VoltageLimit = 5;
                    if (iterator == 0)
                    {
                        pSC1.getOutputHandler(pSC1).VoltageLevel = voltageauto;
                        pSC1.getOutputHandler(pSC1).CurrentLimit = 20;
                        pSC1.getOutputHandler(pSC1).Enabled = true;
                    }
                    else
                    {

                    }
                     
                     //approacher = setpoint - tempData.Last();
                     preapproacher = approacher;
                    //MessageBox.Show("Current Auto" + currentauto +"\nDuration: "+autotimer);
                    //MessageBox.Show("iterotor is :" + iterator + "\nCount is : "+ ctprog1);
                    while (autoloopbreak)
                    {
                        System.Threading.Thread.Sleep(1000);                       
                       // MessageBox.Show("iterotor is :" + iterator + "\n" + "Approach is:" + tempApproach(iterator));\
                        //approacher = tempApproach(setpoint);
                        while (tempData.Count < 3)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                        temp = 0;
                       /* for (int i = 0; i < tempaveraging; i++)
                        {
                            // MessageBox.Show("tempData.Count: " + tempData.Count + "\ntempaveraging: " + tempaveraging + "\ni: " + i);
                            temp += tempData.ElementAt<double>(tempData.Count - 3 + i) / tempaveraging;
                        }*/
                        temp = tempData.Last();
                        worker.ReportProgress(50);
                        //approach = Math.Round( 100*(100 * (ctprogin.temperature - temp / tempaveraging) / (temp / tempaveraging)))/100;
                        approacher = setpoint - temp;// tempData.Last(); 
                       
                        integral+=approacher;
                        if (autotimer < 1)
                        {
                            preapproacher = approacher;
                            derivative = (approacher - preapproacher);
                           
                        }
                        else
                        {
                            derivative = (approacher - preapproacher);
                            preapproacher = approacher;
                        }
                        //label10.Text = "Preapprocher= " + preapproacher + " APproacher= " + approacher;
                        //derivative = (approacher - preapproacher);
                        
                        currentauto = approacher * kp*1+integral*ki*0.001+derivative*kd;
                        
                        //MessageBox.Show("approacher * kp*0.1" + (approacher * kp * 0.1) + " integral*ki*0.01" + (integral * ki * 0.01) + " derivative*kd" + (derivative * kd));
                        //currentauto = approacher * kp;
                        if (currentauto > currentmax)
                        {
                            currentauto = currentmax;
                            
                        }
                        else if (currentauto < currentmin)
                        {
                            currentauto = currentmin;
                        }
                        else
                        {
                            currentauto = currentauto;
                        }

                        pSC1.getOutputHandler(pSC1).CurrentLimit = currentauto;

                        //MessageBox.Show("while in icinde", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //MessageBox.Show("for in icinde i=" + i, "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        
                        worker.ReportProgress(0);

                        if ((worker.CancellationPending == true)) break;
                        if (autotimer <= autoduration)
                        {
                            //MessageBox.Show("simdi true");
                            autoloopbreak = true;
                        }
                        else 
                        {
                            //MessageBox.Show("simdi false");
                            pSC1.getOutputHandler(pSC1).CurrentLimit = 20;
                            autoloopbreak = false; 
                        
                        }

                        autotimer++;
                        totaltimer ++;
                    }
                    iterator++;
                }
                if (contcooling.Enabled)
                {
                    double currentdecreaserate=(double)currentdown.Value;
                    //MessageBox.Show("Control Cooling State= "+contcooling.Enabled, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    int currentstep =(int)(100/(currentdecreaserate));
                    //MessageBox.Show("istep= " + currentstep);
                    if (currentstep > 0)
                    {
                        for (int innerstep = 1; innerstep <= currentstep; innerstep++)
                        {
                            currentauto -=currentauto*currentdecreaserate/100;
                            //MessageBox.Show("I= " + currentauto + " innerstep= " + innerstep + " currentdecreaserate= " + currentdecreaserate);
                            if (currentauto < currentlimit && currentauto>0)
                            {
                                pSC1.getOutputHandler(pSC1).CurrentLimit = currentauto;
                                System.Threading.Thread.Sleep(1000);
                                worker.ReportProgress(0);
                                totaltimer++;
                                coolingtime++;
                            }
                            else
                            {
                                break;
                            }

                        }
                    }

                }
                currentauto = 0;
                pSC1.getOutputHandler(pSC1).CurrentLimit = currentauto;
                pSC1.getOutputHandler(pSC1).Enabled = false;

            }

            catch (Exception ex1)
            {
               // pSC1.disable();
                MessageBox.Show("Auto Start  Button Exception occured :\n" + ex1.Message+" "+ex1.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private double tempApproach(double insetpoint)
        {
            double approach;
            double temp = 0;
            while (tempData.Count<3)
            {
                System.Threading.Thread.Sleep(100);
            }
            for (int i = 0; i < tempaveraging; i++)
            {
               // MessageBox.Show("tempData.Count: " + tempData.Count + "\ntempaveraging: " + tempaveraging + "\ni: " + i);
                temp += tempData.ElementAt<double>(tempData.Count - 3 + i)/tempaveraging;
            } 
            //temp = tempData.Last();
            //approach = Math.Round( 100*(100 * (ctprogin.temperature - temp / tempaveraging) / (temp / tempaveraging)))/100;
            //approach =Math.Round(10*(ctprogin.temperature - temp/tempaveraging))/10;
            approach = insetpoint - temp;
            
            return approach;
        }
        private double tempApproach(ctData ctprogin)
        {
                double approach;
                double temp = 0;
                while (tempData.Count == 0)
                {
                    System.Threading.Thread.Sleep(1000);
                }
                /*for (int i = 0; i < tempaveraging; i++)
                {
                   // MessageBox.Show("tempData.Count: " + tempData.Count + "\ntempaveraging: " + tempaveraging + "\ni: " + i);
                    temp += tempData.ElementAt<double>(tempData.Count - 3 + i);
                } */
                temp = tempData.Last();
                //approach = Math.Round( 100*(100 * (ctprogin.temperature - temp / tempaveraging) / (temp / tempaveraging)))/100;
                //approach =Math.Round(10*(ctprogin.temperature - temp/tempaveraging))/10;
                approach = ctprogin.temperature - temp;
                return approach;          
        }

        private void AnalogInCallback(IAsyncResult ar)
        {
            double[] datasingle;
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    //data = analogInReader.EndReadWaveform(ar);
                    datasingle = analogInReader.ReadSingleSample() ;
                    dataToDataTable(datasingle, ref dataTable);

                    analogInReader.BeginMemoryOptimizedReadWaveform(10, myAsyncCallback, myTask, data);
                }
            }
            catch (DaqException exception)
            {
                MessageBox.Show(exception.Message);
                myTask.Dispose();
                autostartButton.Enabled = true;
                autostopButton.Enabled = false;
                runningTask = null;
            }

        }
        private void bgw_runworkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        private void bgw_progressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                voltageindicator.Text = "Voltage Level = " + pSC1.getOutputHandler(pSC1).VoltageLevel ;//VoltageLevel
                
                currentIndicator.Text = "Current = " + pSC1.getOutputHandler(pSC1).Measure(0x00000000);
                timerindicator.Text = "Remaining time in seconds = "+(autoduration  -timer);
                
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Reading Data Exception occured :\n" + ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void bgwauto_runworkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progInd.Text = "Programs ended";
            currentauto = 0;
            pSC1.getOutputHandler(pSC1).CurrentLimit = 0;
            autocurrentindicator.Text = "" + 0;           
            fs_writer.Close();
            fs.Close();
        }
        private void bgwauto_progressChanged(object sender, ProgressChangedEventArgs e)
        {

            try
            {
                double currentinner = pSC1.getcurrentMeasurement();
                if (contcooling.Enabled)
                {
                    contcoolingcheck = true;
                }
                else
                {
                    contcoolingcheck = false;
                }
                
                if (iterator< ctprog.Count)
                {
                    progInd.Text = "Program " + (iterator + 1) + " in progress";
                    autotimerindicator.Text = "" + (autoduration - autotimer + 1);
                }
                else if (iterator ==  ctprog.Count)
                {
                    if (contcooling.Enabled)
                    {
                        progInd.Text = "Auto Cooling Mode";
                       
                            autotimerindicatorLabel.Text = "Cooling time in seconds  ";
                        
                        autotimerindicator.Text = ""+ coolingtime;
                        
                    }
                    else
                    {
                        progInd.Text = "Programs ended";
                    }
                }
                else
                {
                    progInd.Text = "";
                }

                kp = (double)Kpget.Value;
                ki = (double)Kiget.Value;
                kd = (double)Kdget.Value;
                //error.Text = "kp,ki,kd,I" + kp+" ,"+ki+", "+kd+", "+currentauto;
                double voltageinner = pSC1.getvoltageMeasurement();
                if (currentinner>=200)
                {
                    resistance =setpoint*(voltageinner / currentinner)/0.025;
                }
                else 
                {
                    resistance = setpoint;
 
                }
                autovoltageindicator.Text =  "" + voltageinner;// "Voltage : 5"; //+ pSC1.getOutputHandler(pSC1).Measure(0x00000000);
                //approachlabel.Text = "Error is :" + approacher;
                //label10.Text = "Preapprocher= " + preapproacher + " curr " + currentauto;
                //label11.Text = "integral= " + integral + " Derivative= " + derivative;  
                
                autocurrentindicator.Text = "" + currentinner; //currentauto;//pSC1.getOutputHandler(pSC1).Measure(0x00000000);
                resistanceIndicator.Text=""+(Math.Round(resistance/setpoint*100)/100);
                //tempIndicator.Text =  (Math.Round(1000 * temp) / 1000)+"";//Math.Round(1000 * tempData.Last<double>()) / 1000;
                chart1.Series["tempSeries"].Points.AddXY(totaltimer,tempData.Last<double>());
                chart1.Series["currSeries"].Points.AddXY(totaltimer, currentinner);
                chart1.Series["setpointSeries"].Points.AddXY(totaltimer,setpoint );
                chart1.Series["resistanceSeries"].Points.AddXY(totaltimer, resistance);
                if (fileopened)
                {
                    //fs_writer.WriteLine("TIME,   CURRENT, VOLTAGE,   TEMPERATURE, SETPOINT, PREAPPROACHER, APPROACHER, INTEGRAL, DERIVATIVE , PROGRAM NO");
                    fs_writer.WriteLine("" + totaltimer + ", " + currentinner + ", " + voltageinner + ", " + tempData.Last<double>() + ",   " + setpoint + ",   " + preapproacher + ",   " + approacher + ",   " + integral + ",   " + derivative + ",    " + (iterator + 1) + ",    " + currentmax + ",    " + autoduration); 
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Reading Data Exception occured :\n" + ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
           // pSC1 = new powerSupplyController(psAddress.SelectedIndex);
            pSC1 = new powerSupplyController();
            if (pSC1.getError().Length != 0)
            {
                MessageBox.Show(pSC1.getError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               string s = pSC1.getConnInfo() + "\n" + pSC1.checkConnection();
                if (pSC1.systemstatus)
                {

                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Power supply was succesfully initiated.\n" + s;
                    SaveFileDialog filesave = new SaveFileDialog();
                    filesave.Title = "Save Data File";
                    filesave.ShowDialog();
                    if (filesave.FileName != "")
                    {
                        fs = (System.IO.FileStream)filesave.OpenFile();
                        fileopened = true;
                        fs_writer = new System.IO.StreamWriter(fs);
                    }
                    else
                    {
                        fileopened = false;
                    }

                }                 
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Power supply couldn't be initiated.";                    
                }
            
            //MessageBox.Show(pSC1.getError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            //MessageBox.Show(pSC1.getConnInfo() + "\n" + pSC1.checkConnection(), "Connection Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void psAddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (simulateSelector.Enabled)
            {
                Simulate = "1";
                //MessageBox.Show("Chekbox Enabled tamam value of Simulate=1", "onay kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Simulate = "0";
               // MessageBox.Show("Chekbox Enabled tamam value of Simulate=0", "onay kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (queryInstrumentStatusCheckbox.Enabled)
            {
                QueryInstrStatus = "true";
                MessageBox.Show("Chekbox Enabled tamam value of Query=1", "onay kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                QueryInstrStatus = "false";
                 MessageBox.Show("Chekbox Enabled tamam value of Query=0", "onay kutusu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void manualContselector_CheckedChanged(object sender, EventArgs e)
        {
            if (manualContselector.Enabled) { 
                manualcontrolGroup.Enabled = true;
                autoControlGroup.Enabled = false;
            }
            else { 
                manualcontrolGroup.Enabled = false;
                autoControlGroup.Enabled = true;
            }
            
        }

        private void autoControlSelector_CheckedChanged(object sender, EventArgs e)
        {
            if (autoControlSelector.Enabled)
            {
                manualcontrolGroup.Enabled = false;
                autoControlGroup.Enabled = true;
            }
            else
            {
                manualcontrolGroup.Enabled = true;
                autoControlGroup.Enabled = false;
            }
        }

        private void manStart_Click(object sender, EventArgs e)
        {
            n = time * 1;
            timer = 0;
            loopbreak = true;
            stopsignal = true;
            bgw.RunWorkerAsync();           
            
        }

        private void voltageUpDown_ValueChanged(object sender, EventArgs e)
        {
            voltage = (double)voltageUpDown.Value;
        }

        private void currentUpDown_ValueChanged(object sender, EventArgs e)
        {
            current = (double)currentUpDown.Value;
        }

        private void timeUpDown_ValueChanged(object sender, EventArgs e)
        {
            time = (int)timeUpDown.Value;
        }

        private void manStop_Click(object sender, EventArgs e)
        {
            bgw.CancelAsync();
            //MessageBox.Show("stop signal off", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

        private void autostartButton_Click(object sender, EventArgs e)
        {
            autostartButton.Enabled = false;
            autostopButton.Enabled = true;

            if (!treading)
            {
                this.dataGridView1.SelectAll();
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    ctData ctdata1 = row.DataBoundItem as ctData;
                    if (ctdata1 != null)
                    {
                        // MessageBox.Show("ctDAta" + ctdata1.maximumCurr);
                        ctprog.Add(ctdata1);

                    }


                }
                ctprog.Reverse();
                try
                {
                    double control = ctprog.Last<ctData>().maximumCurr;





                    /* if (ctprog.Count != 0)
                    {
                        MessageBox.Show("You have programmed " + ctprog.Count + " steps");
                    }
                    else if (ctprog.Count == 0)
                    {
                        MessageBox.Show("You don't have any programmed step for Auto mode");
                    }*/

                }
                catch
                {
                    MessageBox.Show("You don't have any programmed step for Auto mode");
                }
                try
                {
                    myTask = new Task();
                    AIChannel myChannel;
                    AIThermocoupleType thermocoupleType;
                    AIAutoZeroMode autoZeroMode;

                    switch (thermocoupleTypeSelector.SelectedIndex)
                    {
                        case 0:
                            thermocoupleType = AIThermocoupleType.T;
                            break;
                        case 1:
                            thermocoupleType = AIThermocoupleType.K;
                            break;
                        case 2:
                            thermocoupleType = AIThermocoupleType.B;
                            break;
                        case 3:
                            thermocoupleType = AIThermocoupleType.E;
                            break;
                        case 4:
                            thermocoupleType = AIThermocoupleType.J;
                            break;
                        case 5:
                            thermocoupleType = AIThermocoupleType.R;
                            break;
                        case 6:
                            thermocoupleType = AIThermocoupleType.S;
                            break;
                        case 7:
                        default:
                            thermocoupleType = AIThermocoupleType.N;
                            break;
                    }

                    myChannel = myTask.AIChannels.CreateThermocoupleChannel(tempReaderChannel.Text,
                                "", Convert.ToDouble(minimumValueNumeric), Convert.ToDouble(maximumValueNumeric),
                                thermocoupleType, AITemperatureUnits.DegreesC, Convert.ToDouble(cjcValueNumeric));
                    autoZeroMode = AIAutoZeroMode.None;
                    myChannel.AutoZeroMode = autoZeroMode;
                    myTask.Timing.ConfigureSampleClock("", Convert.ToDouble(rateNumeric),
                        SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, 1000);





                    myTask.Control(TaskAction.Verify);

                    analogInReader = new AnalogMultiChannelReader(myTask.Stream);

                    runningTask = myTask;
                    InitializeDataTable(myTask.AIChannels, ref dataTable);
                    //acquisitionDataGrid.DataSource = dataTable;

                    // Use SynchronizeCallbacks to specify that the object 
                    // marshals callbacks across threads appropriately.
                    analogInReader.SynchronizeCallbacks = true;
                    analogInReader.BeginReadWaveform(10, myAsyncCallback, myTask);
                }
                catch (DaqException exception)
                {
                    MessageBox.Show("Exception at TC Initialization" + exception.Message);
                    myTask.Dispose();
                    autostartButton.Enabled = true;
                    autostopButton.Enabled = false;
                    runningTask = null;
                }

            }
           
            autotimer = 0;
            autoloopbreak = true;
            autostopsignal = true;
            kp = (double)Kpget.Value;
            ki = (double)Kiget.Value;
            kd = (double)Kdget.Value;            
            bgwauto.RunWorkerAsync();


          

        }
        private void InitializeDataTable(AIChannelCollection channelCollection, ref DataTable data)
        {
            if (channelCollection == null)
                return;

            int numOfChannels = channelCollection.Count;
            data.Rows.Clear();
            data.Columns.Clear();
            dataColumn = new DataColumn[numOfChannels];
            int numOfRows = 10;

            for (int currentChannelIndex = 0; currentChannelIndex < numOfChannels; currentChannelIndex++)
            {
                dataColumn[currentChannelIndex] = new DataColumn();
                dataColumn[currentChannelIndex].DataType = typeof(double);
                dataColumn[currentChannelIndex].ColumnName = channelCollection[currentChannelIndex].PhysicalName;
            }

            data.Columns.AddRange(dataColumn);

            for (int currentDataIndex = 0; currentDataIndex < numOfRows; currentDataIndex++)
            {
                object[] rowArr = new object[numOfChannels];
                data.Rows.Add(rowArr);
            }
        }

       private void dataToDataTable(AnalogWaveform<double>[] sourceArray, ref DataTable dataTable)
        {
            // Iterate over channels
            int currentLineIndex = 0;
            foreach (AnalogWaveform<double> waveform in sourceArray)
            {
                for (int sample = 0; sample < waveform.Samples.Count; ++sample)
                {
                    if (sample == 10)
                        break;

                    dataTable.Rows[sample][currentLineIndex] = waveform.Samples[sample].Value;
                }
                currentLineIndex++;
            }
        }
        private void dataToDataTable(double[] sourceArray, ref DataTable dataTable)
        {
            // Iterate over channels
            //int currentLineIndex = 0;  
            tempData.Add(sourceArray[0]);
           // MessageBox.Show("SAmple Length" + sourceArray.Length);
             //  for (int sample = 0; sample < sourceArray.Length ; ++sample)
             //  {
            tempIndicator.Text = ""+ Math.Round(100*tempData.Last())/100;
            
                   //dataTable.Rows[0][sample] =sourceArray[sample];
            //double q = tempData.Last();
              // }
               
           
        }

        private void acquisitionDataGrid_Navigate(object sender, NavigateEventArgs ne)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tempReaderChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void autostopButton_Click(object sender, EventArgs e)
        {
            dcstop();            

        }
        private void dcstop()
        {
            autostopButton.Enabled = false;
            autostartButton.Enabled = true;
            autoloopbreak = false;
            bgwauto.CancelAsync();
        }   

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void voltageindicator_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_2(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ctDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dcstop();
            runningTask = null;
            myTask.Dispose();           
            autostartButton.Enabled = true;
            //button2.Enabled = false;
        }

        private void label9_Click_2(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Kdget_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Kiget_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Kpget_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void treadButton_Click(object sender, EventArgs e)
        {
            if (!treading)
            {
                treadButton.Enabled = false;
                this.dataGridView1.SelectAll();
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    ctData ctdata1 = row.DataBoundItem as ctData;
                    if (ctdata1 != null)
                    {
                        // MessageBox.Show("ctDAta" + ctdata1.maximumCurr);
                        ctprog.Add(ctdata1);

                    }


                }
                ctprog.Reverse();
                try
                {
                    double control = ctprog.Last<ctData>().maximumCurr;





                    /* if (ctprog.Count != 0)
                    {
                        MessageBox.Show("You have programmed " + ctprog.Count + " steps");
                    }
                    else if (ctprog.Count == 0)
                    {
                        MessageBox.Show("You don't have any programmed step for Auto mode");
                    }*/

                }
                catch
                {
                    MessageBox.Show("You don't have any programmed step for Auto mode");
                }
                try
                {
                    myTask = new Task();
                    AIChannel myChannel;
                    AIThermocoupleType thermocoupleType;
                    AIAutoZeroMode autoZeroMode;

                    switch (thermocoupleTypeSelector.SelectedIndex)
                    {
                        case 0:
                            thermocoupleType = AIThermocoupleType.T;
                            break;
                        case 1:
                            thermocoupleType = AIThermocoupleType.K;
                            break;
                        case 2:
                            thermocoupleType = AIThermocoupleType.B;
                            break;
                        case 3:
                            thermocoupleType = AIThermocoupleType.E;
                            break;
                        case 4:
                            thermocoupleType = AIThermocoupleType.J;
                            break;
                        case 5:
                            thermocoupleType = AIThermocoupleType.R;
                            break;
                        case 6:
                            thermocoupleType = AIThermocoupleType.S;
                            break;
                        case 7:
                        default:
                            thermocoupleType = AIThermocoupleType.N;
                            break;
                    }

                    myChannel = myTask.AIChannels.CreateThermocoupleChannel(tempReaderChannel.Text,
                                "", Convert.ToDouble(minimumValueNumeric), Convert.ToDouble(maximumValueNumeric),
                                thermocoupleType, AITemperatureUnits.DegreesC, Convert.ToDouble(cjcValueNumeric));
                    autoZeroMode = AIAutoZeroMode.None;
                    myChannel.AutoZeroMode = autoZeroMode;
                    myTask.Timing.ConfigureSampleClock("", Convert.ToDouble(rateNumeric),
                        SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, 1000);





                    myTask.Control(TaskAction.Verify);

                    analogInReader = new AnalogMultiChannelReader(myTask.Stream);

                    runningTask = myTask;
                    InitializeDataTable(myTask.AIChannels, ref dataTable);
                    //acquisitionDataGrid.DataSource = dataTable;

                    // Use SynchronizeCallbacks to specify that the object 
                    // marshals callbacks across threads appropriately.
                    analogInReader.SynchronizeCallbacks = true;
                    analogInReader.BeginReadWaveform(10, myAsyncCallback, myTask);
                }
                catch (DaqException exception)
                {
                    MessageBox.Show("Exception at TC Initialization" + exception.Message);
                    myTask.Dispose();
                    autostartButton.Enabled = true;
                    autostopButton.Enabled = false;
                    runningTask = null;
                }
                treading = true;
           
            }
        }

      

      
    }
}
