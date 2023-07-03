using Microsoft.AspNetCore.Components;
using VisaAppV2.Data;

namespace VisaAppV2.Pages;

public partial class Index
{
    [Inject]
    public required AppData AppData { get; set; }
}