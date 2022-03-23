package examples.java.command.dinerLambda;

public class Diner {
	public static void main(String[] args) {
		Cook cook = new Cook();
		Waitress waitress = new Waitress();
		Customer customer = new Customer(waitress, cook);
		customer.createOrder();
		customer.hungry();
	}
}