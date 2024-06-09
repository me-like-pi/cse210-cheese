import numpy as np
import matplotlib.pyplot as plt

# Define the data points
time = np.array([0, 120, 240, 360, 480, 600, 720, 840, 960, 1080, 1200, 1320, 1440])
altitude = np.array([24077, 20173, 17289, 15026, 13035, 11227, 9588, 8100, 6765, 5496, 4337, 3370, 2823])

# Plot the data
plt.figure(figsize=(10, 6))
plt.plot(time, altitude, 'bo', label='Data Points')

# Fit a polynomial curve to the data points
coefficients = np.polyfit(time, altitude, 2)  # Fit a 2nd-degree polynomial
fitted_curve = np.poly1d(coefficients)

# Plot the fitted curve
plt.plot(time, fitted_curve(time), 'r-', label='Fitted Curve')

# Display the equation of the fitted curve
equation = f"{coefficients[0]:.2f}t^2 + {coefficients[1]:.2f}t + {coefficients[2]:.2f}"
plt.text(800, 20000, f"Curve Equation: {equation}", fontsize=12)

# Add labels and legend
plt.xlabel('Time (seconds)')
plt.ylabel('Altitude (m)')
plt.title('Altitude vs. Time during Descent')
plt.legend()

# Show plot
plt.grid(True)
plt.show()

# Extract relevant information from the equation
initial_speed = coefficients[1]  # Coefficient of linear term (t)
initial_height = coefficients[2]  # Constant term
acceleration = 2 * coefficients[0]  # Coefficient of quadratic term (t^2)

print(f"Initial Speed: {initial_speed} m/s")
print(f"Initial Height: {initial_height} m")
print(f"Acceleration: {acceleration} m/s^2")

