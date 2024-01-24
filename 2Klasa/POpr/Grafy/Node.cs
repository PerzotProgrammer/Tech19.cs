namespace Grafy;

public class Node
{
    private List<int> Joints = new();

    public void AddJoint(int on)
    {
        Joints.Add(on);
    }

    public List<int> GetJoints()
    {
        return Joints;
    }
}