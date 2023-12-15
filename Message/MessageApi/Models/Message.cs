using System.ComponentModel.DataAnnotations;

namespace MessageApi.Models;

public class Message
{
    [Key]
    public string? id{get; set;}
    public string? customerName{get; set;}

    public string? message{get;set;}

    public string? date{get; set;}
}