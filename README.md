# Unity-Editor-Autoplay
Plays unity editor everytime the script compiler finishes its processes.

# But why?
Sometimes I don't wanna wait the compile finish to press play.

# How does it work?
Simple check the autorun bool variable at the EditorSettings scriptable object. Then, everytime the compile finishes, editor is gonna play atomatically. Uncheck that variable if you wanna get back to the default setup.
