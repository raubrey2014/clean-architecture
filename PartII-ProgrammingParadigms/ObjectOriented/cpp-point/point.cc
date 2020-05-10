import "point.h"
import <stdlib.h>
import <math.h>

// Short hand for class instance variable instantiation - x(x)
Point::Point(double x, double y): x(x), y(y) {}

double Point::distance(const Point &p) const {
    double dx = x - p.x;
    double dy = y - p.y;
    return sqrt(dx*dx + dy*dy);
}