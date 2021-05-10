#ifndef __TIMER__
#define __TIMER__

#include <functional>
#include <thread>
#include <chrono>
#include "MSException.cpp"

// Represents a class that executes given function of void return type and no parameters every given number of milliseconds.
class MSTimer {
private:
	int interval = 1000;
	std::function<void()> func = [](){};
	std::function<void(MSException)> errorFunc = [](MSException e){};
	bool paused = false;
	bool inProgress = false;
	int initialSleep = 0;

	// A method that loops the given function, waiting given interval (in milliseconds) in between every two calls.
	// If an exception occurs, the timer is automatically paused.
	void call() {
		std::this_thread::sleep_for(std::chrono::milliseconds(initialSleep));

		while (inProgress) {
			if (!paused) {
				try {
					func();
				} catch (MSException e) {
					paused = true;
					errorFunc(e);
				}

				std::this_thread::sleep_for(std::chrono::milliseconds(interval));
			}
		}
	}

public:
	// Creates an empty timer.
	MSTimer() {
	}

	// Creates a timer assigning it a function that is to be executed.
	MSTimer(std::function<void()> f) {
		func = f;
	}

	// Creates a timer assigning it an interval (in milliseconds) that will be waited in between every two function calls.
	MSTimer(int i) {
		interval = i;
	}

	// Creates a timer assigning it a function that is to be executed and interval (in milliseconds) that will be waited in between every two function calls.
	MSTimer(std::function<void()> f, int i) {
		func = f;
		interval = i;
	}

	// Sets an interval (in milliseconds) that will be waited in between every two function calls.
	void setInterval(int i) {
		interval = i;
	}

	// Sets a function that is to be executed.
	void setFunction(std::function<void()> f) {
		func = f;
	}

	// Sets a function that is to be called whenever the exception occurs.
	void setErrorFunction(std::function<void(MSException)> f) {
		errorFunc = f;
	}

	// Returns the timer's interval.
	int getInterval() {
		return interval;
	}

	// Returns the timer's function that is set to be executed.
	auto getFunction() {
		return func;
	}

	// Returns the timer's function that is set to be called whenever the exception occurs.
	auto getErrorFunction() {
		return errorFunc;
	}

	// Checks whether the timer is running.
	bool isInProgress() {
		return inProgress;
	}

	// Checks whether the timer is paused.
	bool isPaused() {
		return paused;
	}
	
	// Starts the timer, causing the given number of milliseconds to be slept first only once.
	void start(int s) {
		inProgress = true;
		initialSleep = s;
		
		std::thread t(&MSTimer::call, this);
		t.detach();
	}

	// Stops the timer.
	void stop() {
		inProgress = false;
	}

	// Pauses the timer.
	void pause() {
		paused = true;
	}

	// Resumes the timer.
	void resume() {
		paused = false;
	}
};

#endif
