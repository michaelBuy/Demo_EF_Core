﻿

namespace Demo_EF_Core.Entities
{
    public class Categorie
    {
        public int Id { get; set; }
        public string? NomCategorie { get; set; }
        public int UtilisateurId { get; set; }

        public virtual ICollection<Contact>? Contacts { get; set; } = new List<Contact>();

    }
}
