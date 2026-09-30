import tkinter #Used to create the GUI
from time import sleep
import customtkinter #Makes the GUI nicer
import serial
import serial.tools.list_ports
from numpy.f2py.crackfortran import previous_context
from sympy.logic.boolalg import Boolean

customtkinter.set_appearance_mode("System")         #Sets the system mode to the default one, in my case was dark theme.
customtkinter.set_default_color_theme("blue")      #Themes: "blue" (standard), "green", "dark-blue"

app = customtkinter.CTk()                               #Lables the app as "app"
app.geometry("720x480")                                 #Sets the resolution
app.title("Python Test")                                #Adds the app title on the top of its window

pic_Serial_Port = serial.Serial()
ports_List = []

manualTitle = customtkinter.CTkLabel(app, text="Manual Control Area") #Creates a label and sets where it shows and what it says
manualTitle.place(relx=0.5, rely=0.25, anchor=customtkinter.CENTER)

button1 = customtkinter.CTkButton(app, text="Position 1", width=75, height=60)
button1.place(relx=0.375, rely=0.35, anchor=customtkinter.CENTER)

button2 = customtkinter.CTkButton(app, text="Position 2", width=75, height=60)
button2.place(relx=0.5, rely=0.35, anchor=customtkinter.CENTER)

button3 = customtkinter.CTkButton(app, text="Position 3", width=75, height=60)
button3.place(relx=0.625, rely=0.35, anchor=customtkinter.CENTER)

button4 = customtkinter.CTkButton(app, text="Position 4", width=75, height=60)
button4.place(relx=0.375, rely=0.5, anchor=customtkinter.CENTER)

button5 = customtkinter.CTkButton(app, text="Position 5", width=75, height=60)
button5.place(relx=0.5, rely=0.5, anchor=customtkinter.CENTER)

button6 = customtkinter.CTkButton(app, text="Position 6", width=75, height=60)
button6.place(relx=0.625, rely=0.5, anchor=customtkinter.CENTER)

button7 = customtkinter.CTkButton(app, text="Position 7", width=75, height=60)
button7.place(relx=0.375, rely=0.65, anchor=customtkinter.CENTER)

button8 = customtkinter.CTkButton(app, text="Position 8", width=75, height=60)
button8.place(relx=0.5, rely=0.65, anchor=customtkinter.CENTER)

button9 = customtkinter.CTkButton(app, text="Position 9", width=75, height=60)
button9.place(relx=0.625, rely=0.65, anchor=customtkinter.CENTER)

commButton = customtkinter.CTkButton(app, text="Update Ports", width=100, height=70)
commButton.place(relx=0.975, rely=0.95, anchor=customtkinter.SE)

picPortComboBox = customtkinter.CTkComboBox(app, width=150)
picPortComboBox.place(relx=0.025, rely=0.05, anchor=customtkinter.NW )

position_data = bytearray(1)
objective_position_global = 0
previous_position_global = 0
steps_multiplying_factor = 4
settings_done = False
manual_port_change = False

def getport1():
    # print("Event Triggered")
    try:
        ports_List.clear()

        for port in serial.tools.list_ports.comports():
            ports_List.append(port.name)

        picPortComboBox.configure(values=ports_List)
        picPortComboBox.set(ports_List[0])
    except:
        picPortComboBox.set("No Ports Available")
    return

def port_change(save_port_name):
    global manual_port_change
    manual_port_change = True
    pic_serial_connect(save_port_name)

    return

def pic_serial_connect(portname):

    global  settings_done, manual_port_change
    if settings_done:
        return
    elif manual_port_change:
        if pic_Serial_Port.is_open:
            pic_Serial_Port.close()

        pic_Serial_Port.port = portname
        pic_Serial_Port.baudrate = 115200
        pic_Serial_Port.open()
        manual_port_change = False

        print(portname,",", str(pic_Serial_Port.baudrate), "btps")

        return

def default_start():
    global previous_position_global, settings_done, manual_port_change
    try:
        if not settings_done:
            getport1()
            port_name = str(picPortComboBox.get())
            manual_port_change = True
            port_change(port_name)
            previous_position_global = 1 * steps_multiplying_factor
            settings_done = True
    except:
        pass
    return

default_start()

def steps_comparison(previous_position = int, objective_position = int):
    tx_position = bytearray(1)
    if objective_position > previous_position:
        tx_position[0] = objective_position - previous_position
        pic_Serial_Port.write(tx_position)
        print("Transmitted Position Hex =", f"{hex(tx_position[0])}", end="")
        print()
        print("Transmitted Position Dec =", f"{int(tx_position[0])}", end="")
        print()
        sleep(15/1000)
    elif objective_position < previous_position:
        tx_position[0] = (previous_position - objective_position) + 128
        pic_Serial_Port.write(tx_position)
        print("Transmitted Position Hex =", f"{hex(tx_position[0])}", end="")
        print()
        print("Transmitted Position Dec =", f"{int(tx_position[0])}", end="")
        print()
        sleep(15 / 1000)
    else:
        print("No Steps Sent, same position as before", end="")
    return

def position_transmission(value = int):
    global position_data, objective_position_global, previous_position_global, steps_multiplying_factor
    position_data[0] = value
    objective_position_global = int(position_data[0]) * steps_multiplying_factor
    print("Objective Position: ", f"{objective_position_global / steps_multiplying_factor}", end="")
    print()
    print("Previous Position: ", f"{previous_position_global / steps_multiplying_factor}", end="")
    print()
    try:
        if objective_position_global != previous_position_global:
            print("Position = ", f"{hex(position_data[0])}", end="")
            print()
            steps_comparison(previous_position_global, objective_position_global)
            sleep(0.015)
            previous_position_global = objective_position_global
    except:
        print(f"Same position as before (Position {position_data[0]}), motor did not move", end="")
        print()
    return

def position1():
    position_transmission(1)
    return
def position2():
    position_transmission(2)
    return
def position3():
    position_transmission(3)
    return
def position4():
    position_transmission(4)
    return

def event_test():
    print("Event Triggered")

def close_app(event=None):
    app.destroy()

app.bind("<Escape>",close_app)
app.bind("<q>",close_app)
app.bind("<Q>",close_app)

commButton.configure(command=getport1)
picPortComboBox.configure(command=port_change)
button1.configure(command=position1)
button2.configure(command=position2)
button3.configure(command=position3)
button4.configure(command=position4)

app.mainloop()
