#region Object Adapter

//using _06_Adapter.ObjectAdapter;

//Target target = new Adapter();

//target.Operation();

#endregion

#region Class Adapter

using _06_Adapter.ClassAdapter;

ITarget target = new Adapter();
target.Operation();

#endregion