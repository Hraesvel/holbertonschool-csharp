abstract class Base {
    public string name;

    public override string ToString(){
        return string.Format("{0} is a {1}", name, this.GetType().Name);
    }
}