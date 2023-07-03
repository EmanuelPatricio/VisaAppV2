using Blazorise;
using Blazorise.LoadingIndicator;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using VisaAppV2.Data;

namespace VisaAppV2.Pages;

public partial class Apply
{
    [Inject]
    public required AppData AppData { get; set; }

    LoadingIndicator loadingIndicator = new();
    DatePicker<DateOnly> datePicker = new();
    int percentage = 0;

    User user = new();

    async Task OnFileChange(InputFileChangeEventArgs e)
    {
        var format = "image/png";
        var resizedImage = await e.File.RequestImageFileAsync(format, 200, 200);
        var buffer = new byte[resizedImage.Size];
        await resizedImage.OpenReadStream().ReadAsync(buffer);
        var imageData = $"data:{format};base64,{Convert.ToBase64String(buffer)}";
        user.DocumentImage = imageData;
    }

    async Task OnValidSubmit()
    {
        await loadingIndicator.Show();

        await Task.Delay(3000);

        AppData.Users.Add(user);
        user = new();

        await loadingIndicator.Hide();
    }
}