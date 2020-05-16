using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Pdf;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Incidents2
{
    public partial class Form1 : Form
    {

        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "Incidents";
        static readonly string SpreadsheetId = "1cJnV5ej7UMOaECldg8cAm6vOtgH05Rim_rIvnU20KR4";
        static readonly string sheet = "Incidents";
        static SheetsService service;

        static string[] compliance_issues;
        static string[] payroll_issues;
        static string[] maintenance_issues;
        static string[] safety_issues;
        static string[] behavioral_issues;
        static string[] report_types;

        private bool addedImg = false;

        public Form1()
        {

            string resource = Path.Combine(System.IO.Path.GetTempPath(), "creds.json");
            File.WriteAllBytes(resource, Properties.Resources.credentials);
            GoogleCredential credential;
            using (var stream = new FileStream(resource, FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }
            service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName
            });

            InitializeComponent();
            
            LoadCombo();
        }

        private void LoadCombo()
        {
            compliance_issues = new string[] {"None", "Citation(Fine)", "Citation (Fine) - Trailer Paperwork Missing", "Citation (Fine) - Truck Paperwork Missing", "Samsara - HOS Violation",
                "Samsara - Not using Samsara App", "Video - Safety Videos Missing", "Violation - E-log Violation", "Violation - Record of Duty Status" };
            payroll_issues = new string[] {"None", "Documentation - Missing Load Paperwork", "Documentation - Missing Receipt", "Documentation - Not Sending Photos to Dispatch",
                "Documentation - Not Sending Picture of Cross Diesel Meter", "Equipment - Damaged Cross Equipment", "Equipment - Damaged Other Equipment", "Equipment - Unauthorized Equipment Displacement",
                "Load - Abandoned", "Load - Confirmed Load Rescheduling", "Load - Delivered Late", "Load - Delivered to Incorrect Location", "Load - Did Not Update ETA", "Load - Dropped Previously Confirmed Load",
                "Load - Picked up Later than Confirmed Pickup Time", "Load - Picked up Late", "Load - Picked up Wrong Load", "Reporting - Not Reporting Fuel to Dispatch", "Reporting - Redirect Load not Reported",
                "Reporting - Split Load not Reported"};
            maintenance_issues = new string[] {"None", "Repair - Brake Issue Reported but Not Repaired", "Repair - Light Issue Reported but Not Repaired", "Repair - Tire Issue Reported but Not Repaired",
                "Reporting - Brake Issue Not Reported", "Reporting - Light Issue Not Reported", "Reporting - Tire Issue Not Reported" };
            safety_issues = new string[] {"None", "Accident  - Accident Not Reported", "Accident  - Accident, at Fault", "Accident - Leaving the Scene of an Accident", "Behavior - Cellphone Distraction",
                "Behavior - Covering Camera", "Behavior - Moving/Disconnecting Camera", "Behavior - No Seatbelt", "Driving - Caused Damage to Other Property", "Driving - Caused Damage to Truck/Trailer",
                "Driving - Driving in Wrong Lane", "Driving - Harsh Turn", "Driving - Not Stopping at Light/Stop Sign", "Driving - Speeding"};
            behavioral_issues = new string[] {"None", "Behavior - Aggressive Toward Customer", "Behavior - Aggressive Toward Employee", "Behavior - Bobtailing Without Instruction To Do So",
                "Behavior - Declined Our Transportation After Calling in due to no Ride", "Behavior - Declining Loads", "Behavior - Not Answering Phone/Text", "Behavior - Not Reporting into Dispatch",
                "Behavior - Not Washing Out as Instructed", "Documentation - Incorrect Manifest/Load Number", "Documentation - Reported Wrong Trailer Number", "Documentation - Reported Wrong Truck Number",
                "Documentation -Incorrect Seals on Paperwork", "Documentation -Missing required Information on Receipts"};
            report_types = new string[] {"Alert", "Incident" };


            compliance_box1.Items.AddRange(compliance_issues);
            compliance_box2.Items.AddRange(compliance_issues);
            compliance_box1.SelectedIndex = 0;
            compliance_box2.SelectedIndex = 0;

            payroll_box1.Items.AddRange(payroll_issues);
            payroll_box2.Items.AddRange(payroll_issues);
            payroll_box1.SelectedIndex = 0;
            payroll_box2.SelectedIndex = 0;

            maintenance_box1.Items.AddRange(maintenance_issues);
            maintenance_box2.Items.AddRange(maintenance_issues);
            maintenance_box1.SelectedIndex = 0;
            maintenance_box2.SelectedIndex = 0;

            safety_box1.Items.AddRange(safety_issues);
            safety_box2.Items.AddRange(safety_issues);
            safety_box1.SelectedIndex = 0;
            safety_box2.SelectedIndex = 0;

            behaviour_box1.Items.AddRange(behavioral_issues);
            behaviour_box2.Items.AddRange(behavioral_issues);
            behaviour_box1.SelectedIndex = 0;
            behaviour_box2.SelectedIndex = 0;

            reportType_box.Items.AddRange(report_types);
            reportType_box.SelectedIndex = 0;

        }

        private void CreateEntry(string[] rows)
        {
            var range = $"{sheet}!A:J";
            var valueRange = new ValueRange();
            var objectList = new List<object>(rows);
            valueRange.Values = new List<IList<object>> { objectList };
            var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendResponse = appendRequest.Execute();
            MessageBox.Show("Record saved.");
        }

        private int GetRecord()
        {
            var range = $"{sheet}!A:A";
            SpreadsheetsResource.ValuesResource.GetRequest request = service.Spreadsheets.Values.Get(SpreadsheetId, range);
            var response = request.Execute();
            IList<IList<object>> values = response.Values;
            if(values != null && values.Count > 0)
            {
                return values.Count;
            }
            return 0;
        }

        private void reportType_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool set = reportType_box.GetItemText(reportType_box.SelectedItem) == "Alert" ? false : true;
            penalty_radio.Enabled = set;
            penalty_radio.Checked = false;

        }

        private void penalty_radio_CheckedChanged(object sender, EventArgs e)
        {
            deducted_amount.Enabled = penalty_radio.Checked;
            if (!deducted_amount.Enabled) deducted_amount.Text = "";
        }

        private void CreateDoc()
        {
            var incidentDate = incident_date.Value;
            var employee = employee_name.Text;
            var truck = truck_number.Text;
            var trailer = trailer_number.Text;
            var location = inc_location.Text;
            var deduction = deducted_amount.Text ?? "0.0";
            var comments = remarks.Text;
            string[] rem = new string[3];
            if (comments.Length > 59)
            {
                if (comments.Length > 129)
                {
                    rem[0] = comments.Substring(0, 59) + "-";
                    rem[1] = comments.Substring(59, 70) + "-";
                    rem[2] = comments.Substring(129, (comments.Length - 129));
                }
                else
                {
                    rem[0] = comments.Substring(0, 59) + "-";
                    rem[1] = comments.Substring(59, (comments.Length - 59));
                }
            }
            else rem[0] = comments;

            var reporter = reporter_name.Text;
            var reportDate = report_date.Value;
            var warning = warning_radio.Checked;
            var warning2 = warning2_radio.Checked;
            var penalty = penalty_radio.Checked;
            var compliance1 = compliance_box1.GetItemText(compliance_box1.SelectedItem);
            var compliance2 = compliance_box2.GetItemText(compliance_box2.SelectedItem);
            var payroll1 = payroll_box1.GetItemText(payroll_box1.SelectedItem);
            var payroll2 = payroll_box2.GetItemText(payroll_box2.SelectedItem);
            var maintenance1 = maintenance_box1.GetItemText(maintenance_box1.SelectedItem);
            var maintenance2 = maintenance_box2.GetItemText(maintenance_box2.SelectedItem);
            var safety1 = safety_box1.GetItemText(safety_box1.SelectedItem);
            var safety2 = safety_box2.GetItemText(safety_box2.SelectedItem);
            var behaviour1 = behaviour_box1.GetItemText(behaviour_box1.SelectedItem);
            var behaviour2 = behaviour_box2.GetItemText(behaviour_box2.SelectedItem);

            string resource = Path.Combine(System.IO.Path.GetTempPath(), "resource.pdf");
            string gen_file = Path.Combine(System.IO.Path.GetTempPath(), "gen_resource.pdf");
            string kind = reportType_box.GetItemText(reportType_box.SelectedItem);
            if (kind == "Incident") File.WriteAllBytes(resource, Properties.Resources.incident_resource);
            else File.WriteAllBytes(resource, Properties.Resources.alert_resource);

            PdfDocument pdf = new PdfDocument(new PdfReader(resource), new PdfWriter(gen_file));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdf, false);
            IDictionary<String, PdfFormField> fields = form.GetFormFields();
            PdfFormField toSet;

            fields.TryGetValue("Employee_Name", out toSet);
            toSet.SetValue(employee);
            fields.TryGetValue("Date_Incident", out toSet);
            toSet.SetValue(incidentDate.ToString("MMMM dd, yyyy"));
            fields.TryGetValue("Location", out toSet);
            toSet.SetValue(location);
            fields.TryGetValue("Truck", out toSet);
            toSet.SetValue(truck);
            fields.TryGetValue("Trailer", out toSet);
            toSet.SetValue(trailer);
            fields.TryGetValue("Warning_Box", out toSet);
            toSet.SetValue(warning ? "Yes" : "Off");
            fields.TryGetValue("Warning2_Box", out toSet);
            toSet.SetValue(warning2 ? "Yes" : "Off");
            fields.TryGetValue("Compliance_Issues", out toSet);
            toSet.SetValue(compliance1);
            fields.TryGetValue("Compliance_Issues2", out toSet);
            toSet.SetValue(compliance2);
            fields.TryGetValue("Payroll_Issues", out toSet);
            toSet.SetValue(payroll1);
            fields.TryGetValue("Payroll_Issues2", out toSet);
            toSet.SetValue(payroll2);
            fields.TryGetValue("Maintenance_Issues", out toSet);
            toSet.SetValue(maintenance1);
            fields.TryGetValue("Maintenance_Issues2", out toSet);
            toSet.SetValue(maintenance2);
            fields.TryGetValue("Safety_Issues", out toSet);
            toSet.SetValue(safety1);
            fields.TryGetValue("Safety_Issues2", out toSet);
            toSet.SetValue(safety2);
            fields.TryGetValue("Behavioral_Issues", out toSet);
            toSet.SetValue(behaviour1);
            fields.TryGetValue("Behavioral_Issues2", out toSet);
            toSet.SetValue(behaviour2);
            fields.TryGetValue("Remarks1", out toSet);
            toSet.SetValue(rem[0] ?? "");
            fields.TryGetValue("Remarks2", out toSet);
            toSet.SetValue(rem[1] ?? "");
            fields.TryGetValue("Remarks3", out toSet);
            toSet.SetValue(rem[2] ?? "");
            if (kind == "Incident")
            {
                fields.TryGetValue("Deducted", out toSet);
                toSet.SetValue(deduction);
                fields.TryGetValue("Penalty_Box", out toSet);
                toSet.SetValue(penalty ? "Yes" : "Off");
            }
            fields.TryGetValue("Incident_Reporter", out toSet);
            toSet.SetValue(reporter);
            fields.TryGetValue("Date_Reported", out toSet);
            toSet.SetValue(reportDate.ToString("MMMM dd, yyyy"));
            form.FlattenFields();
            pdf.Close();
            int rec = GetRecord();

            string[] report = new string[10];
            report[0] = rec.ToString();
            report[1] = employee;
            report[2] = truck;
            report[3] = incidentDate.ToString("MM.dd.y");
            report[4] = reportDate.ToString("MM.dd.y");
            report[5] = reporter;
            report[6] = deduction;
            report[7] = getReason();
            report[8] = "pending";
            report[9] = comments;


            List<string> files = new List<string>
            {
                Path.Combine(Path.GetTempPath(), "gen_resource.pdf")
            };
            if (addedImg)
                files.Add(Path.Combine(Path.GetTempPath(), "images.pdf"));
            string finish = Path.Combine(Path.GetTempPath(), "finished.pdf");

            Merge(files, finish);
            saveFile(finish);
            CreateEntry(report);

            addedImg = false;

        }

        private string getReason()
        {
            string[] build = new string[10];

            build[0] = compliance_box1.GetItemText(compliance_box1.SelectedItem) == "None" ? "" : compliance_box1.GetItemText(compliance_box1.SelectedItem);
            build[1] = compliance_box2.GetItemText(compliance_box2.SelectedItem) == "None" ? "" : compliance_box2.GetItemText(compliance_box2.SelectedItem);
            build[2] = payroll_box1.GetItemText(payroll_box1.SelectedItem) == "None" ? "" : payroll_box1.GetItemText(payroll_box1.SelectedItem);
            build[3] = payroll_box2.GetItemText(payroll_box2.SelectedItem) == "None" ? "" : payroll_box2.GetItemText(payroll_box2.SelectedItem);
            build[4] = maintenance_box1.GetItemText(maintenance_box1.SelectedItem) == "None" ? "" : maintenance_box1.GetItemText(maintenance_box1.SelectedItem);
            build[5] = maintenance_box2.GetItemText(maintenance_box2.SelectedItem) == "None" ? "" : maintenance_box2.GetItemText(maintenance_box2.SelectedItem);
            build[6] = safety_box1.GetItemText(safety_box1.SelectedItem) == "None" ? "" : safety_box1.GetItemText(safety_box1.SelectedItem);
            build[7] = safety_box2.GetItemText(safety_box2.SelectedItem) == "None" ? "" : safety_box2.GetItemText(safety_box2.SelectedItem);
            build[8] = behaviour_box1.GetItemText(behaviour_box1.SelectedItem) == "None" ? "" : behaviour_box1.GetItemText(behaviour_box1.SelectedItem);
            build[9] = behaviour_box2.GetItemText(behaviour_box2.SelectedItem) == "None" ? "" : behaviour_box2.GetItemText(behaviour_box2.SelectedItem);
            string ret = "";

            for (int i = 0; i < build.Length; i++)
            {
                
                if (!string.IsNullOrEmpty(build[i]))
                {
                    if (i == build.Length - 1) ret += build[i];
                    else ret += build[i] + "\n";
                }
            }

            return ret;
        }

        private List<string> getImages()
        {
            List<string> images = new List<string>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|" +
                "All files (*.*)|*.*";
            dialog.Multiselect = true;
            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                foreach (var image in dialog.FileNames)
                {
                    images.Add(image);
                }
            }

            return images;
        }

        public static void Merge(List<string> InFiles, string OutFile)
        {
            using (FileStream stream = new FileStream(OutFile, FileMode.Create))
            using (iTextSharp.text.Document doc = new iTextSharp.text.Document())
            using (iTextSharp.text.pdf.PdfCopy pdf = new iTextSharp.text.pdf.PdfCopy(doc, stream))
            {
                doc.Open();

                iTextSharp.text.pdf.PdfReader reader = null;
                iTextSharp.text.pdf.PdfImportedPage page = null;

                //fixed typo
                InFiles.ForEach(file =>
                {
                    reader = new iTextSharp.text.pdf.PdfReader(file);

                    for (int i = 0; i < reader.NumberOfPages; i++)
                    {
                        page = pdf.GetImportedPage(reader, i + 1);
                        pdf.AddPage(page);
                    }

                    pdf.FreeReader(reader);
                    reader.Close();
                });
            }
        }

        private void viweImg_button_Click(object sender, EventArgs e)
        {
            if (addedImg)
            {
                string finish = Path.Combine(Path.GetTempPath(), "images.pdf");

                System.Diagnostics.Process.Start(finish);
            }
            else MessageBox.Show("No images added.");
        }

        private void addImg_button_Click(object sender, EventArgs e)
        {
            
            string[] images = getImages().ToArray();
            string target = Path.Combine(Path.GetTempPath(), "images.pdf");
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            if (images.Length > 0)
            {
                try
                {
                    iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(target, FileMode.Create));
                    doc.Open();
                    for (int i = 0; i < images.Length; i++)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(images[i]);
                        img.ScaleToFit(500f, 500f);
                        doc.Add(img);
                    }
                }
                finally
                {
                    doc.Close();
                }
                addedImg = true;

                MessageBox.Show("Images added");
            }  

        }

        private void create_button_Click(object sender, EventArgs e)
        {
            CreateDoc();
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (!toggleSwitch1.IsOn)
            {
                this.BackColor = SystemColors.Control;
            }else
            {
                try
                {
                    string hexcolor = Properties.Settings.Default.backColor;
                    if (deducted_amount.Enabled && !string.IsNullOrEmpty(deducted_amount.Text))
                    {
                        hexcolor = deducted_amount.Text;
                        if (hexcolor.Length == 7 && hexcolor[0] == '#')
                        {
                            Properties.Settings.Default.backColor = hexcolor;
                            Properties.Settings.Default.Save();
                        }

                    }
                    this.BackColor = ColorTranslator.FromHtml(hexcolor);
                }
                catch
                {
                }
            }
        }

        public void saveFile(string file)
        {
            // format to save file Cross_Type_Name_Truck_Date
            var incidentDate = incident_date.Value.ToString("MM-dd-yyyy");
            var employee = employee_name.Text;
            var truck = truck_number.Text;
            var kind = reportType_box.GetItemText(reportType_box.SelectedItem);

            string filename = employee+"_"+kind+"_"+incidentDate;


            string dest = Path.Combine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Incidents"), filename);

            if(!Directory.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Incidents"))){
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Incidents"));
            }

            File.Copy(file, IndexedFilename(dest, "pdf"));
        }

        string IndexedFilename(string stub, string extension)
        {
            int ix = 0;
            string filename = null;
            do
            {
                if (!File.Exists(String.Format("{0}.{1}", stub, extension)))
                {
                    return String.Format("{0}.{1}", stub, extension);

                }
                else
                {
                    ix++;
                    filename = String.Format("{0} ({1}).{2}", stub, ix, extension);
                }
            } while (File.Exists(filename));
            return filename;
        }
    }
}
