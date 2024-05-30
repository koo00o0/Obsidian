

<br>

인스턴스는 클래스의 구체적인 실체를 의미합니다.

객체 지향 프로그래밍에서 객체를 정의하는 데 사용되는 설계도나 틀이라고 볼 수 있습니다. 

클래스는 객체의 속성과 행동을 정의하지만, 
실제 메모리에 할당되어 동작하는 객체는 아닙니다.

반면, 인스턴스는 이 클래스를  기반으로 생성된 실제 객체를 말합니다.


```

public class Dog 
{ 
	// 필드 
	public string Name; 
	public int Age; 

	// 메서드 
	public void Bark() 
	{ 
		Console.WriteLine("Woof!"); 
	}

}

```


```
// Dog 클래스의 인스턴스 생성 
Dog myDog = new Dog(); 

// 인스턴스의 속성 설정 
myDog.Name = "Buddy"; 
myDog.Age = 3; 

// 인스턴스의 메서드 호출 
myDog.Bark(); // 출력: Woof!
```


### Class와 Instance의 차이

#### Class
- 객체의 속성과 동작을 정의하는 청사진입니다. 메모리에 할당되지 않고, 그자체로는 실행되지 않습니다 .

#### Instance
- 클래스를 기반으로 생성된 실제 객체입니다 . 메모리에 할당되어 실제 데이터를  저장하고 메서드를 실행할 수 있습니다 . 


### 인스턴스와 메모리
각 인스턴스는 독립적으로 메모리에 할당됩니다. 예를 들어, 'myDog'와 'anotherDog'는 서로 다른 메모리 공간을 차지하며, 각자의 속성 값을 가집니다.

```
Dog myDog = new Dog(); 
myDog.Name = "Buddy"; 

Dog anotherDog = new Dog(); 
anotherDog.Name = "Charlie";

Console.WriteLine(myDog.Name); // 출력: Buddy Console.WriteLine(anotherDog.Name); // 출력: Charlie

```