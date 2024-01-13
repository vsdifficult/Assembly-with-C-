[DllImport("kernel32.dll")]

unsafe void* InvokeAsm(void* firstAsmArg, void* secondAsmArg, byte[] code) { 
     unsafe static extern bool VirtualProtect(int* lpAddress, uint dwSize, uint flNewProtect, uint* lpflOldProtect);
     int i = 0; 
     int* p = &i; 
     p += 0x14 / 4 + 1; 
     i = *p; 
     fixed (byte* b = code) { 
         *p = (int)b; 
         uint prev; 
         VirtualProtect((int*)b, (uint)code.Length, 0x40, &prev); 
     }
     return (void*)i;  
}    


