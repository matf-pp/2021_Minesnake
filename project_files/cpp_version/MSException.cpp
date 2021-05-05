#ifndef __EXCEPTION__
#define __EXCEPTION__

// Defines exceptions that can occur.
enum MSException {
	SIZE_INSUFFICIENT,
	INDEX_OUT_OF_BOUNDS,
	NO_STARTING_TILE,
	SNAKE_SIZE_INVALID,
	SNAKE_IN_INVALID_POSITION,
	SNAKE_ON_A_MINE,
	SNAKE_ON_FOOD,
	USER_ERROR_CLICKED_ON_MINE,
	USER_ERROR_MISSED_MINE,
	HOW_DID_WE_GET_HERE
};

#endif