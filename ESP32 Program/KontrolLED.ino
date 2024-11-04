#define L1 18
#define L2 19
#define L3 21
#define L4 22
#define L5 23

String dataString;
char data;

void setup() {
  Serial.begin(115200);

  pinMode(L1, OUTPUT);
  pinMode(L2, OUTPUT);
  pinMode(L3, OUTPUT);
  pinMode(L4, OUTPUT);
  pinMode(L5, OUTPUT);

  digitalWrite(L1, LOW);
  digitalWrite(L2, LOW);
  digitalWrite(L3, LOW);
  digitalWrite(L4, LOW);
  digitalWrite(L5, LOW);
}

void loop() {
  if (Serial.available() > 0) {
    dataString = Serial.readString();
    char data = dataString.charAt(0);

    if (data == 'A') {
      digitalWrite(L1, HIGH); // Nyalakan LED pada pin 18
    } 
    else if (data == 'a') {
      digitalWrite(L1, LOW); // Matikan LED pada pin 18
    } 
    else if (data == 'B') {
      digitalWrite(L2, HIGH); // Nyalakan LED pada pin 19
    } 
    else if (data == 'b') {
      digitalWrite(L2, LOW); // Matikan LED pada pin 19
    } 
    else if (data == 'C') {
      digitalWrite(L3, HIGH); // Nyalakan LED pada pin 21
    } 
    else if (data == 'c') {
      digitalWrite(L3, LOW); // Matikan LED pada pin 21
    } 
    else if (data == 'D') {
      digitalWrite(L4, HIGH); // Nyalakan LED pada pin 22
    } 
    else if (data == 'd') {
      digitalWrite(L4, LOW); // Matikan LED pada pin 22
    } 
    else if (data == 'E') {
      digitalWrite(L5, HIGH); // Nyalakan LED pada pin 23
    } 
    else if (data == 'e') {
      digitalWrite(L5, LOW); // Matikan LED pada pin 23
    }
    // matikan semua led jika disconnect
    else if (data == 'f') {
      digitalWrite(L1, LOW);
      digitalWrite(L2, LOW);
      digitalWrite(L3, LOW);
      digitalWrite(L4, LOW);
      digitalWrite(L5, LOW);
    }
  }
}
