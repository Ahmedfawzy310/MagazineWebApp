namespace Magazine.Models
{
    public class EditFormViewModel
    {
        public int Id { get; set; }
        public List<string>?CurrentCovers { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public int GenderId { get; set; }
        public List<int> SelectedAudinces { get; set; } = default!;
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<SelectListItem> TargetAudinces { get; set; } = Enumerable.Empty<SelectListItem>();
        public IEnumerable<SelectListItem> Genders { get; set; } = Enumerable.Empty<SelectListItem>();
        [AllowedAttrebuite(SettingsForForm.AllowdExtension)]
        public List<IFormFile>? Images { get; set; } = default!;
    }
}
