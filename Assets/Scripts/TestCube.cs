using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ICommand
{
    void Execute();
    void Dispose();
}

public abstract class Command : ICommand
{
    void ICommand.Dispose()
    {
        OnDispose();
    }
    protected abstract void OnDispose();
    void ICommand.Execute()
    {
        OnExecute();    
    }
    protected abstract void OnExecute();
}

public class Cube : Command
{
    protected override void OnDispose()
    {
        Debug.Log("Dispose Cube");
    }

    protected override void OnExecute()
    {
        Debug.Log("Execute Cube");
    }
}

public static class CommandExecuter
{
    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();
        command.Dispose();
    }
}


public class TestCube : MonoBehaviour
{
    private void Start()
    {
        var cube = new Cube();
        // cube.Excute();  非法
        
        //CommandExecuter.ExecuteCommand(cube); //合法
    }
}
