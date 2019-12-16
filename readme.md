
# Project InterDingsda

This project demonstrates interfaces and it's paraphernalia.

### Abstract method

### Virtual method

### Interface, notably IEnumerable

### Type casting


### Notes

 Todo : Class Dingsda was only created to have one type which can be used
 as mother type of all. The .NET provides such class as 'Object',
 but I avoided that class, just for not so convincing reasons.
 Now I think I shoule rather **eliminate the Dingsda class**,
 and leave it's job to Object.
 (1) This would allow demo code lines like casting from dedicated type
 to Object and back from Object to dedicated type, which is an actual real-world demand.
 (2) It would make the UML diagram simpler and more clearly telling,
  that Vehicles and Dragons have nothing in common except the interface. 
<sub><sup>[todo 20191212°1913]</sup></sub>


 Todo : Not all methods are use so far, e.g. Park(), Clean(). Use them.
<sub><sup>[todo 20191212°1923]</sup></sub>

---

### Versions

InterDingsda v0.1.1 Initial version

InterDingsda v0.1.x Remove the artificial object 'Dingsda' class and replace it by the .NET native Object class.

---
 <sub><sup>[file 20191216°1431][project 20191212°0011]܀Ω</sup></sub>
