using System.ComponentModel.DataAnnotations;

namespace API.Requests;

public record ArtistaRequest([Required] string nome, [Required] string bio);