using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using Microsoft.VisualStudio.Services.WebApi.Patch;
using Microsoft.VisualStudio.Services.WebApi.Patch.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFSAPI
{
    static class Program
    {
        static  void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.Run(new TFSAPI());
            ////// Get 2 levels of query hierarchy items
            ////List<QueryHierarchyItem> queryHierarchyItems = witClient.GetQueriesAsync("STSV3 Test", depth: 2).Result;

            ////// Search for 'My Queries' folder
            ////QueryHierarchyItem myQueriesFolder = queryHierarchyItems.FirstOrDefault(qhi => qhi.Name.Equals("My Queries"));
            ////if (myQueriesFolder != null)
            ////{
            ////    string queryName = "GID11Insights";

            ////    // See if our 'REST Sample' query already exists under 'My Queries' folder.
            ////    QueryHierarchyItem newBugsQuery = null;
            ////    if (myQueriesFolder.Children != null)
            ////    {
            ////        newBugsQuery = myQueriesFolder.Children.FirstOrDefault(qhi => qhi.Name.Equals(queryName));
            ////    }
            ////    if (newBugsQuery == null)
            ////    {
            ////        // if the 'REST Sample' query does not exist, create it.
            ////        newBugsQuery = new QueryHierarchyItem()
            ////        {
            ////            Name = queryName,
            ////            Wiql = "SELECT [System.Id],[System.WorkItemType],[System.Title],[System.AssignedTo],[System.State],[System.Tags] FROM WorkItems WHERE [System.TeamProject] = @project AND [System.WorkItemType] = 'Test Case'",
            ////            IsFolder = false
            ////        };
            ////        newBugsQuery = witClient.CreateQueryAsync(newBugsQuery, "STSV3 Test", myQueriesFolder.Name).Result;
            ////    }

            ////    // run the 'REST Sample' query
            ////    WorkItemQueryResult result = witClient.QueryByIdAsync(newBugsQuery.Id).Result;

            ////    if (result.WorkItems.Any())
            ////    {
            ////        int skip = 0;
            ////        const int batchSize = 100;
            ////        IEnumerable<WorkItemReference> workItemRefs;
            ////        do
            ////        {
            ////            workItemRefs = result.WorkItems.Skip(skip).Take(batchSize);
            ////            if (workItemRefs.Any())
            ////            {
            ////                // get details for each work item in the batch
            ////                List<WorkItem> workItems = witClient.GetWorkItemsAsync(workItemRefs.Select(wir => wir.Id)).Result;
            ////                foreach (WorkItem workItem in workItems)
            ////                {
            ////                    // write work item to console
            ////                    Console.WriteLine("{0} {1}", workItem.Id, workItem.Fields["System.Title"]);
            ////                }
            ////            }
            ////            skip += batchSize;
            ////        }
            ////        while (workItemRefs.Count() == batchSize);
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("No work items were returned from query.");
            ////    }
            ////}
        }     
    }

}

