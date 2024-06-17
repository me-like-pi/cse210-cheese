import numpy as np
import matplotlib.pyplot as plt

# Define the function and its derivatives
def f(x):
    return -x**4 + 4*x**3 - 10

def f_prime(x):
    return -4*x**3 + 12*x**2

def f_double_prime(x):
    return -12*x**2 + 24*x

# Generate x values
x = np.linspace(-1, 4, 400)
y = f(x)

# Plot the function
plt.figure(figsize=(10, 6))
plt.plot(x, y, label=r'$f(x) = -x^4 + 4x^3 - 10$')

# Identify critical points and inflection points
critical_points_x = [0, 3]
critical_points_y = [f(0), f(3)]
inflection_points_x = [0, 2]
inflection_points_y = [f(0), f(2)]

# Plot critical points and inflection points
plt.plot(critical_points_x, critical_points_y, 'ro', label='Critical Points')
plt.plot(inflection_points_x, inflection_points_y, 'go', label='Inflection Points')

# Fill regions
x_increasing_1 = np.linspace(-1, 0, 100)
x_increasing_2 = np.linspace(0, 3, 100)
x_decreasing = np.linspace(3, 4, 100)
plt.fill_between(x_increasing_1, f(x_increasing_1), alpha=0.2, color='yellow', label='Increasing')
plt.fill_between(x_increasing_2, f(x_increasing_2), alpha=0.2, color='yellow')
plt.fill_between(x_decreasing, f(x_decreasing), alpha=0.2, color='cyan', label='Decreasing')

x_concave_up = np.linspace(0, 2, 100)
x_concave_down_1 = np.linspace(-1, 0, 100)
x_concave_down_2 = np.linspace(2, 4, 100)
plt.fill_between(x_concave_up, f(x_concave_up), alpha=0.2, color='pink', label='Concave Up')
plt.fill_between(x_concave_down_1, f(x_concave_down_1), alpha=0.2, color='orange', label='Concave Down')
plt.fill_between(x_concave_down_2, f(x_concave_down_2), alpha=0.2, color='orange')

# Add labels and legend
plt.title('Graph of $f(x) = -x^4 + 4x^3 - 10$')
plt.xlabel('x')
plt.ylabel('f(x)')
plt.legend(loc='best')
plt.grid(True)
plt.show()



# import numpy as np
# import matplotlib.pyplot as plt

# # Define the function and its derivative
# def f(x):
#     return (2*x**2 + x - 1) / (x**2 - 1)

# # Derivatives
# def f_prime(x):
#     return (2*(x**2-1) * (4*x + 1) - (2*x**2 + x - 1) * (2*x)) / (x**2 - 1)**2

# def f_double_prime(x):
#     return (-12*x**2 * (4*x + 1) + 4*(x**2-1)**2) / (x**2 - 1)**3

# # Generate x values avoiding the discontinuities at x = 1 and x = -1
# x = np.linspace(-3, 3, 400)
# x = x[(x != -1) & (x != 1)]
# y = f(x)

# # Plot the function
# plt.figure(figsize=(10, 6))
# plt.plot(x, y, label=r'$y = \frac{2x^2 + x - 1}{x^2 - 1}$')

# # Plot vertical asymptotes
# plt.axvline(x=1, color='r', linestyle='--', label='Vertical Asymptote x=1')
# plt.axvline(x=-1, color='r', linestyle='--', label='Vertical Asymptote x=-1')

# # Plot horizontal asymptote
# plt.axhline(y=2, color='g', linestyle='--', label='Horizontal Asymptote y=2')

# # Calculate and plot points of interest
# x_values = np.linspace(-3, 3, 1000)
# x_values = x_values[(x_values != -1) & (x_values != 1)]
# f_prime_values = f_prime(x_values)
# f_double_prime_values = f_double_prime(x_values)

# # Identify regions where the graph is increasing/decreasing
# increasing = x_values[f_prime_values > 0]
# decreasing = x_values[f_prime_values < 0]
# concave_up = x_values[f_double_prime_values > 0]
# concave_down = x_values[f_double_prime_values < 0]

# plt.fill_between(increasing, f(increasing), color='yellow', alpha=0.3, label='Increasing')
# plt.fill_between(decreasing, f(decreasing), color='cyan', alpha=0.3, label='Decreasing')
# plt.fill_between(concave_up, f(concave_up), color='pink', alpha=0.3, label='Concave Up')
# plt.fill_between(concave_down, f(concave_down), color='orange', alpha=0.3, label='Concave Down')

# # Add intercepts
# plt.plot(0, 1, 'bo', label='y-intercept (0,1)')
# plt.plot(0.5, 0, 'ro', label='x-intercept (0.5,0)')

# # Add labels and legend
# plt.title('Graph of $y = \\frac{2x^2 + x - 1}{x^2 - 1}$')
# plt.xlabel('x')
# plt.ylabel('y')
# plt.ylim(-10, 10)
# plt.legend(loc='best')
# plt.grid(True)
# plt.show()














# # import numpy as np
# # import matplotlib.pyplot as plt

# # # Define the data points
# # time = np.array([0, 120, 240, 360, 480, 600, 720, 840, 960, 1080, 1200, 1320, 1440])
# # altitude = np.array([24077, 20173, 17289, 15026, 13035, 11227, 9588, 8100, 6765, 5496, 4337, 3370, 2823])

# # # Plot the data
# # plt.figure(figsize=(10, 6))
# # plt.plot(time, altitude, 'bo', label='Data Points')

# # # Fit a polynomial curve to the data points
# # coefficients = np.polyfit(time, altitude, 2)  # Fit a 2nd-degree polynomial
# # fitted_curve = np.poly1d(coefficients)

# # # Plot the fitted curve
# # plt.plot(time, fitted_curve(time), 'r-', label='Fitted Curve')

# # # Display the equation of the fitted curve
# # equation = f"{coefficients[0]:.2f}t^2 + {coefficients[1]:.2f}t + {coefficients[2]:.2f}"
# # plt.text(800, 20000, f"Curve Equation: {equation}", fontsize=12)

# # # Add labels and legend
# # plt.xlabel('Time (seconds)')
# # plt.ylabel('Altitude (m)')
# # plt.title('Altitude vs. Time during Descent')
# # plt.legend()

# # # Show plot
# # plt.grid(True)
# # plt.show()

# # # Extract relevant information from the equation
# # initial_speed = coefficients[1]  # Coefficient of linear term (t)
# # initial_height = coefficients[2]  # Constant term
# # acceleration = 2 * coefficients[0]  # Coefficient of quadratic term (t^2)

# # print(f"Initial Speed: {initial_speed} m/s")
# # print(f"Initial Height: {initial_height} m")
# # print(f"Acceleration: {acceleration} m/s^2")

