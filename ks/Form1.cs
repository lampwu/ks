using System.Globalization;
using System.Runtime.InteropServices;
using VisaComLib;
//using System.Threading;
//using System.Threading.Tasks;
using System.Diagnostics;

namespace ks
{
    public partial class soft_start : Form
    {
        public soft_start()
        {
            InitializeComponent();
        }

        public class usbSendAndRead
        {
            static ResourceManager? resourceManager;
            static FormattedIO488? ioObject;
            public static bool Write(string address, string command)
            {
                resourceManager = new ResourceManager();
                ioObject = new FormattedIO488();
                try
                {
                    ioObject.IO = (IMessage)resourceManager.Open(address, AccessMode.NO_LOCK, 2000, "");
                    //Thread.Sleep(20);
                    ioObject.WriteString(data: command, flushAndEND: true);

                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    try { ioObject.IO.Close(); }
                    catch { }
                    try { Marshal.ReleaseComObject(ioObject); }
                    catch { }
                    try { Marshal.ReleaseComObject(resourceManager); }
                    catch { }
                }

            }

            public static bool Read(string address, out string valueRead)
            {
                resourceManager = new ResourceManager();
                ioObject = new FormattedIO488();

                //string addr = $"GPIB::{address.ToString()}::INSTR";

                try
                {
                    ioObject.IO = (IMessage)resourceManager.Open(address, AccessMode.NO_LOCK, 2000, "");
                    //Thread.Sleep(20);
                    valueRead = ioObject.ReadString();

                    return true;
                }
                catch
                {
                    valueRead = "";
                    return false;
                }
                finally
                {
                    try { ioObject.IO.Close(); }
                    catch { }
                    try { Marshal.ReleaseComObject(ioObject); }
                    catch { }
                    try { Marshal.ReleaseComObject(resourceManager); }
                    catch { }
                }
            }
        }

        bool stop_start_state = false;
        private async void button_start_Click(object sender, EventArgs e)
        {
            string source_load_address = textBox_address.Text;
            if (source_load_address == "")
            {
                MessageBox.Show("address error", "Message");
                return;
            }
            //usbSendAndRead.Write(source_load_address, "CURR:LIM 0");
            //usbSendAndRead.Write(source_load_address, "VOLT 0");
            usbSendAndRead.Write(source_load_address, "OUTP ON");
            label_status.Text = "running";
            stop_start_state = true;
            string read_current;
            string read_voltage;
            await Task.Delay(1000);

            while (stop_start_state == true)
            {
                //Debug.Print("start:");

                //Debug.Print(DateTime.Now.ToString());
                usbSendAndRead.Write(source_load_address, "MEAS:CURR?");
                usbSendAndRead.Read(source_load_address, out read_current);

                usbSendAndRead.Write(source_load_address, "MEAS:VOLT:ACDC?");
                usbSendAndRead.Read(source_load_address, out read_voltage);
                //Debug.Print(read_current);
                //Debug.Print(read_voltage);
                label_meas_current.Text = float.Parse(read_current, CultureInfo.InvariantCulture).ToString("0.00");
                label_meas_voltage.Text = float.Parse(read_voltage, CultureInfo.InvariantCulture).ToString("0.00");

                //Debug.Print("end:");
                await Task.Delay(1000);


                //Debug.Print(DateTime.Now.ToString());
                //await Task.Delay(500);

                //Debug.Print("after 1s");

                //Debug.Print(DateTime.Now.ToString());

                //await Task.Delay(1000);

            }


        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            string source_load_address = textBox_address.Text;
            if (source_load_address == "")
            {
                MessageBox.Show("address error", "Message");
                return;
            }
            usbSendAndRead.Write(source_load_address, "OUTP OFF");
            label_status.Text = "stop";
            stop_start_state = false;


        }

        private void textBox_setup_current_value_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (textBox_setup_current_value.Text == "") { return; }
            //string source_load_address = textBox_address.Text;
            //usbSendAndRead.Write(source_load_address, "CURR:LIM " + textBox_setup_current_value.Text.ToString());
            number = float.Parse(textBox_setup_current_value.Text, CultureInfo.InvariantCulture);
            vScrollBar1.Value = (int)(number * 10);

            //vScrollBar1.Value = Int32.Parse(textBox_setup_current_value.Text)*10;
        }

        private void vScrollBar_voltage_ValueChanged(object sender, EventArgs e)
        {
            string source_load_address = textBox_address.Text;
            string voltage_set = (((float)vScrollBar_voltage.Value) / 10).ToString("0.00");
            Debug.Print(voltage_set);
            usbSendAndRead.Write(source_load_address, "VOLT " + voltage_set);
            textBox_setup_voltage_value.Text = voltage_set;
        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            string source_load_address = textBox_address.Text;
            //setup_current_value.Text = vScrollBar1.Value.ToString();
            //textBox_setup_current_value.Text = (vScrollBar1.Value / 10).ToString();
            //float number = float.Parse(vScrollBar1.Value,CultureInfo.InvariantCulture);
            string current_lim = (((float)vScrollBar1.Value) / 10).ToString("0.00");
            usbSendAndRead.Write(source_load_address, "CURR:LIM " + current_lim);
            textBox_setup_current_value.Text = current_lim;


        }

        private void textBox_setup_voltage_value_TextChanged(object sender, EventArgs e)
        {
            float number;
            if (textBox_setup_voltage_value.Text == "") { return; }
            number = float.Parse(textBox_setup_voltage_value.Text, CultureInfo.InvariantCulture);

            vScrollBar_voltage.Value = (int)(number * 10);

        }
        private void CheckEnterKeyPressV(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                float number;
                if (textBox_setup_voltage_value.Text == "") { return; }
                number = float.Parse(textBox_setup_voltage_value.Text, CultureInfo.InvariantCulture);

                vScrollBar_voltage.Value = (int)(number * 10);
                // Then Do your Thang
            }
        }

        private void CheckEnterKeyPressC(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)

            {
                float number;
                if (textBox_setup_current_value.Text == "") { return; }
                //string source_load_address = textBox_address.Text;
                //usbSendAndRead.Write(source_load_address, "CURR:LIM " + textBox_setup_current_value.Text.ToString());
                number = float.Parse(textBox_setup_current_value.Text, CultureInfo.InvariantCulture);
                vScrollBar1.Value = (int)(number * 10);
                // Then Do your Thang
            }
        }
    }
}