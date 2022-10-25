class CategoryValue
{
    public Category Category { get; set; } = Category.Mobile;
    public string Value { get; set; } = string.Empty;
}

enum Category
{
    Undefined,
    Mobile,
    Work,
    Home,
    Extra
}