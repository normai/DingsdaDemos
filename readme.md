
# Project InterDingsda

This project demonstrates interfaces and their paraphernalia.

The paraphernalia are :

- Abstract method

- Virtual method

- Interface, notably IEnumerable

- Type casting

### Versions

##### InterDingsda v0.1.1

Initial version.

As the top parent class it has the dedicated class 'Dingsda', which is
only introduced as quick'n'dirty helper to avoid dealing dealing with the
Object class itself. How to use the Object class, we will demonstrate in
the next version.

##### InterDingsda v0.1.3

Remove the artificial object 'Dingsda' class and replace it by the .NET native Object class.
The steps are :

- The original file/class 'Dingsda' war renamed to **static** file/class 'Utils'.
This was done, because that file contains the static various lists we already had,
and which continue to exist exactly as they are.

- Replace 'List<Dings> dings' by 'List<**Object**> dings'

- To retain the object's ID and Me property, we introduced interface **ICountable**

To inspect the changes of the transformation, see the GIT logs with
comment 'Adjust syntax' and 'Restore functionality'.

### Todo

Not all methods are use so far, e.g. Park(), Clean(). Use them.
<sub><sup>[todo 20191212°1923]</sup></sub>

---
 <sub><sup>[file 20191216°1431][project 20191212°0011]܀Ω</sup></sub>
