using DevExpress.Blazor;

namespace GridTest.Client;

public static class GridPageState
{
    public static Patient? SelectedPatient { get; set; }
    public static int PageIndex { get; set; }
    public static GridPersistentLayout? Layout { get; set; }
}