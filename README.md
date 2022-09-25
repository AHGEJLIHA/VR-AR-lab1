# ВИРТУАЛЬНАЯ И ДОПОЛНЕННАЯ РЕАЛЬНОСТЬ
Отчет по лабораторной работе #1 выполнил(а):
- Шкатова Ангелина Валерьевна
- РИ-300017
Отметка о выполнении заданий (заполняется студентом):

| Задание | Выполнение | Баллы |
| ------ | ------ | ------ |
| Задание 1 | * | 100 |
| Задание 2 | * | 100 |
| Задание 3 | * | 100 |

знак "*" - задание выполнено; знак "#" - задание не выполнено;

Работу проверили:
- к.т.н., доцент Денисов Д.В.
- к.э.н., доцент Панов М.А.
- ст. преп., Фадеев В.О.

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

Структура отчета

- Данные о работе: название работы, фио, группа, выполненные задания.
- Цель работы.
- Задание 1.
- Задание 2.
- Задание 3.
- Выводы.
- ✨Magic ✨

## Цель работы
...

## Задание 1
### ...
Ход работы:
1. Создать новый проект из шаблона 3D – Core;
![image](https://user-images.githubusercontent.com/79083395/192144209-ea7e0f25-080e-44ab-a173-b8e4004160fa.png)

2. Проверить, что настроена интеграция редактора Unity и Visual Studio Code
(пункты 8-10 введения);
![image](https://user-images.githubusercontent.com/79083395/192144255-a765143e-4af8-4462-9469-151073ac937e.png)

3. Создать объект Plane;
![image](https://user-images.githubusercontent.com/79083395/192144267-3ed86e1e-1fe2-4243-af0f-68b7c1344c3e.png)

4. Создать объект Cube;
![image](https://user-images.githubusercontent.com/79083395/192144279-df572553-72b4-4a2b-b888-b781cd5b798d.png)

5. Создать объект Sphere;
![image](https://user-images.githubusercontent.com/79083395/192144299-35e08b41-cf63-4e58-9e82-fbeaf6d0653e.png)

6. Установить компонент Sphere Collider для объекта Sphere;
![image](https://user-images.githubusercontent.com/79083395/192144366-ee843a45-a706-4f24-9c3d-6215d65a29dc.png)

7. Настроить Sphere Collider в роли триггера;
![image](https://user-images.githubusercontent.com/79083395/192144393-5be7fe79-e3f9-47dc-a8e7-6cf9ad359a5a.png)

8. Объект куб перекрасить в красный цвет;
![image](https://user-images.githubusercontent.com/79083395/192144417-1885dc52-4349-4422-b1f7-2bb503c24bf6.png)

9. Добавить кубу симуляцию физики, при это куб не должен проваливаться под Plane;
![image](https://user-images.githubusercontent.com/79083395/192144474-c080f075-923d-4603-a233-b48ab896479d.png)

10. Написать скрипт, который будет выводить в консоль сообщение о том, что объект Sphere столкнулся с объектом Cube;
![Unity_HlksMJdKVx](https://user-images.githubusercontent.com/79083395/192145373-e01c528f-370e-47bd-ad2f-a0c564e8ba98.gif)
```C#
using UnityEngine;

public class CheckCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Произошло столкновение с " + other.gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Завершено столкновение с " + other.gameObject.name);
    }
}
```

11. При столкновении Cube должен менять свой цвет на зелёный, а при завершении столкновения обратно на красный.
- Выключим свойство "IsTrigger" у Sphere;
- Добавим компонент RigidBody с "Use Gravity" = "True", "Is Kinematic" = "False";
- Добавим скрипт "CheckCollision";
![Unity_QvuxfFSWJe](https://user-images.githubusercontent.com/79083395/192146011-80277b76-72d0-416e-8e3d-8e4cb55430c3.gif)
```C#
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }
    
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
            collision.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
    }
}
```

## Задание 2
### ...

## Задание 3
### ...

## Выводы
Абзац умных слов о том, что было сделано и что было узнано.

**BigDigital Team: Denisov | Fadeev | Panov**
