## Singleton Design Pattern

* Belongs to Creational Pattern
* Deals with Instance creation
* Ensure only one Instance is created for a class in the application

### Implementation 
* Declare all the constructor method in the class as private
* Private static property that holds Instance of the class
* Static method that returns created Instance 
* Make the class as sealed class

### Why Sealed Class?
* Restricted class Inheritance
* In case the singleton class is not sealed, it throws the below error when any class try to Inherit 
  ```
  Error: Singleton is inaccessible due to its protection level
  ```
  This error is due to the private constructor in the singleton class. 
  * The private constructor is accessible in the Nested class. The singleton can be inherited 
  * It will not throw the inaccessible error since the private constructor can be called inside
  * Due to that the Singleton pattern will be violated since it creates more than Instance
```
public class Singleton
{
    private static Singleton Instance = null;
    private Singleton(){

    }

    //Nested class
    public class Derived: Singleton
    {
        //Invoke Singleton constructor and creates object.
    }
}
```
* Due to this issue the Singleton class should be sealed

### Multi Thread Safety
The implementation in SimpleSingleton works fine in the Single thread or linear execution.

In the multithread it creates more than one instance and it violates the Singleton design pattern concept

```
public static void NoThreadSafety(){
    Parallel.Invoke(
        ()=>PrintEmp(),
        ()=>PrintStudent()
    );
}
```
**Output:**

![alt text](asset/image.png)

### Thread Safety
* Implement Obj lock to avoid creating more than one Instance
  * Refer SingletonThreadSafe class
  ```
  private static readonly object obj = new object();

  lock(obj)
  {
    if(Instance==null)
    {
        Instance = new SingletonThreadSafe();
    }
  }
  ```
* Implement Double Check Locking
  * Locking obj is expensive and reduce the performance
  * Check instance is created or not before lock
  ```
  if(Instance==null)
  {
      lock(obj)
      {
          if(Instance==null)
          {
              Instance = new SingletonThreadSafe();
          }
      }
  }
  ```

### Lazy Loading
* Instance is created when its required
* Improve Performance  and Reduces the memory
  
### Eager Loading
* Instance is created at the time of application start-up
* It creates Instance is created and will be available instead of creating on-demand 
* CLR takes care of creating the instance
* 


  