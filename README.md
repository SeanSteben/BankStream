BankStream - Secure Transaction Simulator
BankStream is a Windows console application built on the .NET framework, designed to simulate transactions between a user and a bank while incorporating various security methods. This educational tool serves a dual purpose by providing users with a practical understanding of transaction security practices and highlighting potential vulnerabilities intentionally embedded in the system.

Features
User Interface (UI):
The application offers a user-friendly interface that simulates the interaction between the user and the bank.

Information Display:
There are dedicated forms to display information being passed between the user and the bank, showcasing both encrypted and unencrypted data.

Bank Interaction:
A third form illustrates the bank's perspective, displaying the information received and the corresponding response.

Encryption Method:
BankStream employs the LSFR (Linear Feedback Shift Register) encryption method to secure transactions.

Password Security:
The project emphasizes the importance of password security by implementing hashing and salting techniques.


Educational Focus:
BankStream is intentionally designed with certain flaws to serve as an educational tool. These intentional weaknesses include:

  Pseudo-Random Numbers:
  The use of pseudo-random numbers introduces a vulnerability that demonstrates the importance of true randomness in cryptographic applications.

  Fixed Keys:
  Fixed keys in the encryption process highlight the risks associated with using static encryption keys.

  One-Way Encryption:
  Encryption in a single direction exposes the limitation of one-way encryption, emphasizing the benefits of two-way encryption methods.

  LSFR vs A5/1:
  The intentional choice of LSFR over more secure alternatives like A5/1 highlights the importance of selecting robust encryption algorithms.

!!!Security Disclaimer!!!:
BankStream intentionally incorporates security weaknesses for educational purposes. Do not use this application in a production environment, as it is not intended for real-world transactions.
