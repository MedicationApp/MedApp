// using Microsoft.AspNetCore.Components;  
// using System.Collections.Generic;  
// using Project.Models;
// // using Project.Models.UserState;
//
// namespace BlazorComponents.Pages  
// {  
//     public class MedCheckBox : ComponentBase  
//     {  
//         public List<Medication> medList { get; set; }  
//         protected List<string> SelectedIds = new List<string>();  
//         // public List<Employee> ObjectList { get; set; }  
//         public string OutPutValue { get; set; }  
//         protected override void OnInitialized()  
//         {  
//             medList = GetMockEmployees();  
//         }  
//   
//         protected void ShowSelectedValues()  
//         {  
//             OutPutValue = string.Join(",", SelectedIds.ToArray());   
//             StateHasChanged();  
//         }  
//         private List<Medication> GetMockEmployees()
//         {
//             var patient = UserState.getPatient();
//             medList = UserState.getPatient().medList;
//             return medList;
//         }  
//     }
// } 