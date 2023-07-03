using System;
using System.Collections.Generic;

namespace VisaAppV2.Data.Models;

public partial class Solicitud
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateTime BornDate { get; set; }

    public int Gender { get; set; }

    public int DocumentType { get; set; }

    public string DocumentNumber { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int MaritalStatus { get; set; }

    public string DocumentImage { get; set; } = null!;
}
