# Assembly-with-C- 

```
http://ref.x86asm.net
```
# how use? 

```
static void Main() { 
     unsafe { 
          InvokeAsm((void*)0, (void*)0, new SASMCode ( 
          @"
          YOUR ASM CODE
          "
          ).Code);  

     } 
}
```
