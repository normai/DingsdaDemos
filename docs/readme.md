# Additional notes

## 1. Todos

<sub><sup>[todo 20191218°1631]</sup></sub>
Rename interface 'ICountable' to 'IRegisterable'.

Introduce LINQ demo <sub><sup>[todo 20191218°1313]</sup></sub>

Not all methods are used so far, e.g. Park(), Clean(). Use them.
<sub><sup>[todo 20191212°1923]</sup></sub>

---

*[todo : Check the correctness of the following listing.]*

## 2. Development Phases or Tags

### 2.1 Development Phase 3 2019-Dec-18

Introduces sequences to demonstrate **IEnumerable**

This is from when the solution resides on GitHub

### 2.2 Development Phase 2

This are Tags ~~'Last-multi-phase-folders' 20191217°1000
and ~~'interdings-v0-3-0' 20191217°1022

Remove the artificial object 'Dingsda' class and replace it by the .NET native Object class.
The steps are :

- The original file/class 'Dingsda' war renamed to **static** file/class 'Utils'.
This was done, because that file contains the static various lists we already had,
and which continue to exist exactly as they are.

- Replace 'List<Dings> dings' by 'List<**Object**> dings'

- To retain the object's ID and Me property, we introduced interface **ICountable**

![Overview Project Interdingsda](./20191216o1733.interdingsda.uxf.png "Project Interdingsda Phase 2")

To inspect the changes of the transformation, see the GIT logs with
comment 'Adjust syntax' and 'Restore functionality'.

### 2.3 Development Phase 1

This is Tag 'InterDings.v011' 20191216°1441

Initial version.

As the top parent class functions the dedicated class 'Dingsda', which is
only introduced as quick'n'dirty helper to avoid dealing dealing with the
Object class itself. How to use the Object class, we will demonstrate in
the next version.

![Overview Project Interdingsda](./20191212o1211.interdingsda.uxf.png "Project Interdingsda Phase 1")

---

<sup><sub><sup>*[file 20191216°1431]* ܀Ω</sup></sub></sup>
