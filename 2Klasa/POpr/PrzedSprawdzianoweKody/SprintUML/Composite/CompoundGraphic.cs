namespace SprintUML.Composite;

public class CompoundGraphic : IGraphic
{
    private List<IGraphic> Children = new();

    public void Add(IGraphic child)
    {
        Children.Add(child);
    }

    public void Remove(IGraphic child)
    {
        Children.Remove(child);
    }

    public void Move(int x, int y)
    {
        foreach (IGraphic child in Children) child.Move(x, y);
    }

    public void Draw()
    {
        foreach (IGraphic child in Children) child.Draw();
    }
}