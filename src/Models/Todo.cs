using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FuncCs.Models
{
  /// <summary>
  /// Todo
  /// </summary>
  [Table("todos")]
  public class Todo
  {
    /// <summary>
    /// Constructor
    /// </summary>
    public Todo() : base()
    {
    }

    /// <summary>
    /// Id
    /// </summary>
    [Column("id")]
    [Key]
    public Guid Id { get; set; }

    /// <summary>
    /// Content
    /// </summary>
    [Column("content")]
    [Required, StringLength(128)]
    public string Content { get; set; }
  }
}
