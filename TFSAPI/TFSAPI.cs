using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFSAPI
{
    public partial class TFSAPI : Form
    {
        public TFSAPI()
        {
            InitializeComponent();
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                VssConnection connection = new VssConnection(new Uri("http://vmlvktfs1.dev.haav.com/DefaultCollection"), new VssCredentials());
                WorkItemTrackingHttpClient witClient = connection.GetClient<WorkItemTrackingHttpClient>();
                List<int> testcasesid = new List<int>();
                string[] fileData = File.ReadAllLines(txtPath.Text);
                foreach (string line in fileData)
                {
                    testcasesid.Add(Convert.ToInt32(line));
                }
                lblStatus.Text = "Loading all work items";
                List<WorkItem> workitems = witClient.GetWorkItemsAsync(testcasesid).Result;
                lblStatus.Text = "All work items loaded successfully";
                if (chkIterationPath.Checked)
                {
                    if (txtiteration.Text != "")
                    {
                        foreach (var workitem in workitems)
                        {
                            //if (workitem.Fields["System.State"].ToString() == "Not Implemented")
                            //{
                            int itemID = Convert.ToInt32(workitem.Id);
                            lblStatus.Text = "Started Operation on Test Case " + itemID;
                            JsonPatchDocument patchDocument = new JsonPatchDocument();
                            patchDocument.Add(
                                new JsonPatchOperation()
                                {
                                    Operation = Operation.Add,
                                    Path = "/fields/System.IterationPath",
                                    Value = txtiteration.Text
                                }
                            );
                            WorkItem result = witClient.UpdateWorkItemAsync(patchDocument, itemID).Result;
                            lblStatus.Text = "Test Case with ID " + itemID + " Ieration path has been Updated";
                            ///System.Threading.Thread.Sleep(60000);
                            //Console.WriteLine(" {0}: {1}", workitem.Id, workitem.Fields["System.Title"]);
                            //}
                        }
                    }
                }
                else if (chkAssignedTo.Checked)
                {
                    if (txtassignedTo.Text != "")
                    {
                        foreach (var workitem in workitems)
                        {
                            //if (workitem.Fields["System.State"].ToString() == "Not Implemented")
                            //{
                            int itemID = Convert.ToInt32(workitem.Id);
                            lblStatus.Text = "Started Operation on Test Case " + itemID;
                            JsonPatchDocument patchDocument = new JsonPatchDocument();
                            patchDocument.Add(
                                new JsonPatchOperation()
                                {
                                    Operation = Operation.Add,
                                    Path = "/fields/System.AssignedTo",
                                    Value = txtassignedTo.Text
                                }
                            );
                            WorkItem result = witClient.UpdateWorkItemAsync(patchDocument, itemID).Result;
                            lblStatus.Text = "Test Case with ID " + itemID + " Assigned To has been Updated";
                            ///System.Threading.Thread.Sleep(60000);
                            //Console.WriteLine(" {0}: {1}", workitem.Id, workitem.Fields["System.Title"]);
                            //}
                        }
                    }
                }
                else if (chkrhtxtbox.Checked)
                {
                    //string[] RichTextBoxLines = rchtxtbox.Lines;
                    if (rchtxtbox.Text != "")
                    {
                        foreach (var workitem in workitems)
                        {
                            //if (workitem.Fields["System.State"].ToString() == "Not Implemented")
                            //{
                            string description = "";
                            if (workitem.Fields.ContainsKey("System.Description"))
                            {
                                description = workitem.Fields["System.Description"].ToString();
                            }
                            description = rchtxtbox.Text + description;
                            int itemID = Convert.ToInt32(workitem.Id);
                            lblStatus.Text = "Started Operation on Test Case " + itemID;
                            JsonPatchDocument patchDocument = new JsonPatchDocument();
                            patchDocument.Add(
                                new JsonPatchOperation()
                                {
                                    Operation = Operation.Add,
                                    Path = "/fields/System.Description",
                                    Value = description
                                }
                            );
                            WorkItem result = witClient.UpdateWorkItemAsync(patchDocument, itemID).Result;
                            lblStatus.Text = "Test Case with ID " + itemID + " Description path has been Updated";
                            ///System.Threading.Thread.Sleep(60000);
                            //Console.WriteLine(" {0}: {1}", workitem.Id, workitem.Fields["System.Title"]);
                            //}
                        }
                    }
                }
                else if (chkareapath.Checked)
                {
                    //string[] RichTextBoxLines = rchtxtbox.Lines;
                    if (txtarepath.Text != "")
                    {
                        foreach (var workitem in workitems)
                        {
                            int itemID = Convert.ToInt32(workitem.Id);
                            lblStatus.Text = "Started Operation on Test Case " + itemID;
                            JsonPatchDocument patchDocument = new JsonPatchDocument();
                            patchDocument.Add(
                                new JsonPatchOperation()
                                {
                                    Operation = Operation.Add,
                                    Path = "/fields/System.AreaPath",
                                    Value = txtarepath.Text
                                }
                            );
                            WorkItem result = witClient.UpdateWorkItemAsync(patchDocument, itemID).Result;
                            lblStatus.Text = "Test Case with ID " + itemID + " Area path has been Updated";
                            ///System.Threading.Thread.Sleep(60000);
                            //Console.WriteLine(" {0}: {1}", workitem.Id, workitem.Fields["System.Title"]);
                            //}
                        }
                    }
                }
                else
                {
                    foreach (var workitem in workitems)
                    {
                        if (workitem.Fields["System.State"].ToString() == "Not Implemented")
                        {
                            int itemID = Convert.ToInt32(workitem.Id);
                            lblStatus.Text = "Started Operation on Test Case " + itemID;
                            JsonPatchDocument patchDocument = new JsonPatchDocument();
                            patchDocument.Add(
                                new JsonPatchOperation()
                                {
                                    Operation = Operation.Add,
                                    Path = "/fields/System.State",
                                    Value = "Ready for Test"
                                }
                            );
                            WorkItem result = witClient.UpdateWorkItemAsync(patchDocument, itemID).Result;
                            lblStatus.Text = "Test Case with ID " + itemID + " Status has been Updated";
                            ///System.Threading.Thread.Sleep(60000);
                            //Console.WriteLine(" {0}: {1}", workitem.Id, workitem.Fields["System.Title"]);
                        }
                    }
                }
                lblStatus.Text = "All Test Cases Updated Successfully";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
 
