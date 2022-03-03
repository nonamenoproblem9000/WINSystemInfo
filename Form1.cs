using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowSystemInfos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadInfoBTN_Click(object sender, EventArgs e)
        {
            Schreiben();
        }

        static readonly string[] SizeSuffixes = { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        static string SizeSuffix(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag]);
        }

        static ulong GetTotalMemoryInBytes()
        {
            return new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;
        }


        public static string RamType
        {
            get
            {
                int type = 0;

                ConnectionOptions connection = new ConnectionOptions();
                connection.Impersonation = ImpersonationLevel.Impersonate;
                ManagementScope scope = new ManagementScope("\\\\.\\root\\CIMV2", connection);
                scope.Connect();
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_PhysicalMemory");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    type = Convert.ToInt32(queryObj["MemoryType"]);
                }

                return TypeString(type);
            }
        }

        private static string TypeString(int type)
        {
            string outValue = string.Empty;

            switch (type)
            {
                case 0x0: outValue = "Unknown"; break;
                case 0x1: outValue = "Other"; break;
                case 0x2: outValue = "DRAM"; break;
                case 0x3: outValue = "Synchronous DRAM"; break;
                case 0x4: outValue = "Cache DRAM"; break;
                case 0x5: outValue = "EDO"; break;
                case 0x6: outValue = "EDRAM"; break;
                case 0x7: outValue = "VRAM"; break;
                case 0x8: outValue = "SRAM"; break;
                case 0x9: outValue = "RAM"; break;
                case 0xa: outValue = "ROM"; break;
                case 0xb: outValue = "Flash"; break;
                case 0xc: outValue = "EEPROM"; break;
                case 0xd: outValue = "FEPROM"; break;
                case 0xe: outValue = "EPROM"; break;
                case 0xf: outValue = "CDRAM"; break;
                case 0x10: outValue = "3DRAM"; break;
                case 0x11: outValue = "SDRAM"; break;
                case 0x12: outValue = "SGRAM"; break;
                case 0x13: outValue = "RDRAM"; break;
                case 0x14: outValue = "DDR"; break;
                case 0x15: outValue = "DDR2"; break;
                case 0x16: outValue = "DDR2 FB-DIMM"; break;
                case 0x17: outValue = "Undefined 23"; break;
                case 0x18: outValue = "DDR3"; break;
                case 0x19: outValue = "FBD2"; break;
                case 0x1a: outValue = "DDR4"; break;
                default: outValue = "Undefined"; break;
            }
            return outValue;
        }

        private string gpuSearchQuery = "";
        private string cpuSearchQuery = "";


        private void Schreiben()
        {

             


            /*  INITIALIZE  */
       


            foreach (ManagementObject item in system.Get())
            {
                RamBox.Text += SizeSuffix((long)GetTotalMemoryInBytes());
                
            }

            foreach (ManagementObject item  in cpus.Get())
            {
                ProcessorBox.Text += item["Name"];
                cpuSearchQuery += item["Name"];
            }
            foreach (ManagementObject item in gpus.Get())
            {
                GrafikBox.Text += item["VideoProcessor"] + " - Version: ";
                GrafikBox.Text += item["DriverVersion"];
                gpuSearchQuery += item["VideoProcessor"];
            }
            foreach (DriveInfo item in drives)
            {
                DriveBox.Text += ("Drive "+ item.Name) + "\n";
                DriveBox.Text += ("  Drive type: "+ item.DriveType) + "\n";
                DriveBox.Text += "....................................................................................." + "\n";
                if (item.IsReady == true)
                {
                    DriveBox.Text += ("  Volume label: "+ item.VolumeLabel) + "\n";
                    DriveBox.Text += ("  File system: "+ item.DriveFormat) + "\n";
                    DriveBox.Text += ("  Available space to current user: " + SizeSuffix(item.AvailableFreeSpace)) + "\n";

                    DriveBox.Text += ("  Total available space:        "+ SizeSuffix(item.TotalFreeSpace)) + "\n";

                    DriveBox.Text += ("  Total size of drive:          "+ SizeSuffix(item.TotalSize)) + "\n";
                    DriveBox.Text += ("  Root directory:               "+ item.RootDirectory) + "\n";
                    DriveBox.Text += "---------------------------------------------------" + "\n";
                }
            }
            foreach (ManagementObject item in oss.Get())
            {
                OSBox.Text += item["Caption"];
                SerialBox.Text += item["Serialnumber"];
                OSVersionBox.Text = (string)item["Version"];
            }
            foreach (ManagementObject item in printers.Get())
            {
                PrinterBox.Text += ("Name  -  " + item["Name"]) + "\n";
                PrinterBox.Text += ("Network  -  " + item["Network"]) + "\n";
                PrinterBox.Text += ("Availability  -  " + item["Availability"]) + "\n";
                PrinterBox.Text += ("Is default printer  -  " + item["Default"]) + "\n";
                PrinterBox.Text += ("DeviceID  -  " + item["DeviceID"]) + "\n";
                PrinterBox.Text += ("Status  -  " + item["Status"]) + "\n";
                PrinterBox.Text += "---------------------------------------------------" + "\n";
            }
            foreach (ManagementObject item in sounds.Get())
            {
                SoundBox.Text+=("Name  -  " + item["Name"]) + "\n";
                SoundBox.Text += ("ProductName  -  " + item["ProductName"]) + "\n";
                SoundBox.Text += ("Availability  -  " + item["Availability"]) + "\n";
                SoundBox.Text += ("DeviceID  -  " + item["DeviceID"]);
                SoundBox.Text += ("PowerManagementSupported  -  " + item["PowerManagementSupported"]) + "\n";
                SoundBox.Text += ("Status  -  " + item["Status"]) + "\n";
                SoundBox.Text += ("StatusInfo  -  " + item["StatusInfo"]) + "\n";
                SoundBox.Text += "---------------------------------------------------" + "\n";


            }

            ShowNetworkConnections();
            MainboardBox.Text += "Status : " + Availability + "\n" + "Hersteller : " + Manufacturer + "\n" + "Model : " + Product + "\n" + "Beschädigt : " + Status + "\n" + "Version : " + Version + "\n";

        }




        private static ManagementObjectSearcher baseboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_BaseBoard");
        private static ManagementObjectSearcher motherboardSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_MotherboardDevice");

        static public string Availability
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in motherboardSearcher.Get())
                    {
                        return GetAvailability(int.Parse(queryObj["Availability"].ToString()));
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public bool HostingBoard
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        if (queryObj["HostingBoard"].ToString() == "True")
                            return true;
                        else
                            return false;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        static public string InstallDate
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return ConvertToDateTime(queryObj["InstallDate"].ToString());
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string Manufacturer
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Manufacturer"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string Model
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Model"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string PartNumber
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["PartNumber"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string PNPDeviceID
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["PNPDeviceID"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string PrimaryBusType
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["PrimaryBusType"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string Product
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Product"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public bool Removable
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        if (queryObj["Removable"].ToString() == "True")
                            return true;
                        else
                            return false;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        static public bool Replaceable
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        if (queryObj["Replaceable"].ToString() == "True")
                            return true;
                        else
                            return false;
                    }
                    return false;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        static public string RevisionNumber
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["RevisionNumber"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string SecondaryBusType
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["SecondaryBusType"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string SerialNumber
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["SerialNumber"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string Status
        {
            get
            {
                try
                {
                    foreach (ManagementObject querObj in baseboardSearcher.Get())
                    {
                        return querObj["Status"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string SystemName
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in motherboardSearcher.Get())
                    {
                        return queryObj["SystemName"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        static public string Version
        {
            get
            {
                try
                {
                    foreach (ManagementObject queryObj in baseboardSearcher.Get())
                    {
                        return queryObj["Version"].ToString();
                    }
                    return "";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
        }

        private static string GetAvailability(int availability)
        {
            switch (availability)
            {
                case 1: return "Other";
                case 2: return "Unknown";
                case 3: return "Running or Full Power";
                case 4: return "Warning";
                case 5: return "In Test";
                case 6: return "Not Applicable";
                case 7: return "Power Off";
                case 8: return "Off Line";
                case 9: return "Off Duty";
                case 10: return "Degraded";
                case 11: return "Not Installed";
                case 12: return "Install Error";
                case 13: return "Power Save - Unknown";
                case 14: return "Power Save - Low Power Mode";
                case 15: return "Power Save - Standby";
                case 16: return "Power Cycle";
                case 17: return "Power Save - Warning";
                default: return "Unknown";
            }
        }

        private static string ConvertToDateTime(string unconvertedTime)
        {
            string convertedTime = "";
            int year = int.Parse(unconvertedTime.Substring(0, 4));
            int month = int.Parse(unconvertedTime.Substring(4, 2));
            int date = int.Parse(unconvertedTime.Substring(6, 2));
            int hours = int.Parse(unconvertedTime.Substring(8, 2));
            int minutes = int.Parse(unconvertedTime.Substring(10, 2));
            int seconds = int.Parse(unconvertedTime.Substring(12, 2));
            string meridian = "AM";
            if (hours > 12)
            {
                hours -= 12;
                meridian = "PM";
            }
            convertedTime = date.ToString() + "/" + month.ToString() + "/" + year.ToString() + " " +
            hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString() + " " + meridian;
            return convertedTime;
        }





        private void ShowNetworkConnections()
        {

            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            NetworkBox.Text += "Interface informationen für : " + computerProperties.HostName+computerProperties.DomainName + "\n";
            if (nics == null || nics.Length < 1)
            {
                NetworkBox.Text = "   Keine Netzwerke Gefunden!";
                return;
            }

            NetworkBox.Text += "  Anzahl Interfaces : " + nics.Length + "\n";
            NetworkBox.Text += "\n";

            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();

                NetworkBox.Text += (adapter.Description);
                NetworkBox.Text += "\n";
                NetworkBox.Text += ("  Interface type .............................. : " + adapter.NetworkInterfaceType) + "\n";
                NetworkBox.Text += ("  Physical Address ........................ : " + adapter.GetPhysicalAddress().ToString()) + "\n";
                NetworkBox.Text += ("  Operational status ...................... : " + adapter.OperationalStatus) + "\n";
                
                string versions = "";

                // Create a display string for the supported IP versions.
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    versions = "IPv4";
                }
                if (adapter.Supports(NetworkInterfaceComponent.IPv6))
                {
                    if (versions.Length > 0)
                    {
                        versions += " ";
                    }
                    versions += "IPv6";
                }
                NetworkBox.Text += ("  IP version ..................................... : "+ versions) + "\n";
                //ShowIPAddresses(properties);

                // The following information is not useful for loopback adapters.
                if (adapter.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                {
                    continue;
                }
                NetworkBox.Text += ("  DNS suffix .................................... : " + properties.DnsSuffix) + "\n";

                string label;
                if (adapter.Supports(NetworkInterfaceComponent.IPv4))
                {
                    IPv4InterfaceProperties ipv4 = properties.GetIPv4Properties();
                    NetworkBox.Text += ("  MTU............................................... : " + ipv4.Mtu) + "\n";
                    if (ipv4.UsesWins)
                    {

                        IPAddressCollection winsServers = properties.WinsServersAddresses;
                        if (winsServers.Count > 0)
                        {
                            label = "  WINS Servers ............................ : ";
                            //ShowIPAddresses(label, winsServers);
                        }
                    }
                }
                
                NetworkBox.Text += ("  DNS enabled ................................ : " + properties.IsDnsEnabled) + "\n";
                NetworkBox.Text += ("  Dynamically configured DNS..... : " + properties.IsDynamicDnsEnabled) + "\n";
                NetworkBox.Text += ("  Receive Only ................................ : " + adapter.IsReceiveOnly) + "\n";
                NetworkBox.Text += ("  Multicast ...................................... : " + adapter.SupportsMulticast) + "\n";
                NetworkBox.Text += "\n";
                NetworkBox.Text += "---------------------------------------------------" + "\n";
            }

        }
        public ManagementObjectSearcher cpus = new ManagementObjectSearcher("select * from Win32_Processor");
        public ManagementObjectSearcher gpus = new ManagementObjectSearcher("select * from Win32_VideoController");
        public DriveInfo[] drives = DriveInfo.GetDrives();
        public ManagementObjectSearcher oss = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
        public ManagementObjectSearcher printers = new ManagementObjectSearcher("select * from Win32_Printer");
        public ManagementObjectSearcher sounds = new ManagementObjectSearcher("select * from Win32_SoundDevice");
        public NetworkInterface[] nis = NetworkInterface.GetAllNetworkInterfaces();
        public ManagementObjectSearcher system = new ManagementObjectSearcher("select * from Win32_ComputerSystem");


        
    }
}
