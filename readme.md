﻿<img src="./docs/20211206o1243.red-helicopter.v1.x0256y0133.png" align="right" width="179" height="93" alt="Icon 20211206°1243" id="id20211206o1432">

# DingsdaDemos &nbsp; <sup><sub><sup>v0.3.1</sup></sub></sup>

## 1. Synopsis

**Platform** : C-Sharp, Visual Studio 2019, DotNet 4.8

**Slogan** : Understand some non-trivial C-Sharp features

**Summary** : This solution hosts some project to demonstrate
some non-trivial C-Sharp features like interface, IEnumerator, etc.

**License** : The MIT-License

**Authors** : Norbert C. Maier and contributors

**Copyright** : Norbert C. Maier and contributors

## 2. Projects

- [InterDings](./InterDings/readme.md).
The main project, this contains also the class hierarchy
which is used by the other projects

- [IEnumablDings](./IEnumablDings/readme.md).
This contains a class which implements the IEnumerable<> interface
and shows how to use it.

## 3. The story

The class hierarchy created in the InterDings project can be used
from the other projects as well. The story goes like follows.

![Project Interdingsda Overview](./docs/20191218o1641.interdingsda.uxf.png "Project Interdingsda class hierarchy")

### 3.1 Actors

The main actor is the **Vehicle**.
The Vehicle is abstract, because in the real world, you find only concrete incarnations of them.

The **Automobile** is a Vehicle which can drive.
The driving ability is established by method Drive(), which can be inherited.

The **Airplane** is a Vehicle which can fly.
But we do not establish the flying ability by a method Fly() here,
because also other very different objects can fly, e.g. the dragon.
This is why Fly() is introduced by interface **IFlyable**.

The **Boat** is of course a Vehicle.
The swimming ability is, like with flying, not established by a method for inheritance
but by interface **ISwimmable**.

The **Amphibious** is a Vehicle. Since it can drive, it can be inherited from Automobile.
This uses up the inheritance, and the swimming capability is introduce by interface **ISwimmable**.

The **Airtaxi** is also Vehicle. It inherits it's driving capability from the Automobile,
and the flying capability is introduced by interface IFlyable.

The **Dragon** has nothing to do with the vehicles at all,
just it can also fly with interface IFlyable.

The **IFlyable** interface provides some objects the flying capability.

The **ISwimmable** interface provides some objects the swimming capability.

The **ICountable** interface provides all classes in the game some common
addressing properties, so we can have a list of just all existing things.

### 3.2 Points of Interest

The ICountable interface could be replaced by extension methods on the Object class.
But we shyed away from this move, because we do not want touch the .NET core functionality.

...

## 4 Credits

The top right logo comes from
 [openclipart.org/detail/172801/helicopter](https://openclipart.org/detail/172801/helicopter)
 under the
 [CC0 1.0 Universal](https://creativecommons.org/publicdomain/zero/1.0/)
 Public Domain Dedication
 

---

<sup><sub><sup>*[file 20191216°1717] [solution 20191212°0011]* ܀Ω</sup></sub></sup>
