using Classes;

Color red = new Color (255, 0, 0);
Color white = new Color (255, 255, 255);
Ball basketBall = new Ball (10, red);
Ball golfBall = new Ball (1, white);

golfBall.Throw();
golfBall.Throw();
golfBall.Throw();
basketBall.Throw();
basketBall.Throw();
basketBall.Throw();
basketBall.Throw();
basketBall.Throw();
basketBall.Throw();

Console.WriteLine(golfBall.GetThrowCount());
Console.WriteLine(basketBall.GetThrowCount());