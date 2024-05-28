import numpy as np
import matplotlib.pyplot as plt

def f(x):
    if x < 2 or x == 5:
        return np.nan  # Representing undefined values with NaN (Not a Number)
    elif 2 <= x < 5:
        return 3
    else:
        return 1 / (x - 5)

# Generate x values
x_values = np.linspace(-10, 10, 400)  # Generating x values from -10 to 10

# Compute y values using the function
y_values = [f(x) for x in x_values]

# Plotting
plt.figure(figsize=(8, 6))
plt.plot(x_values, y_values, label='f(x)', color='blue')
plt.xlabel('x')
plt.ylabel('f(x)')
plt.title('Graph of the function f(x)')
plt.grid(True)
plt.axhline(0, color='black',linewidth=0.5)
plt.axvline(0, color='black',linewidth=0.5)
plt.legend()
plt.show()
