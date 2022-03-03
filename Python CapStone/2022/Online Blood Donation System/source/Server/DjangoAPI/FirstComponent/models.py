from operator import mod
from django.db import models

# Create your models here.
class Register(models.Model):
    Id = models.AutoField( primary_key=True)
    firstname = models.CharField(max_length=50, blank=False, default="")
    lastname = models.CharField(max_length=50, blank=False, default="")
    dateOfBirth = models.DateField(max_length=50, blank=False, default="")
    Email = models.CharField(max_length=50, blank=False, default="")
    phone = models.IntegerField( blank=False, default="")
    country = models.CharField(max_length=50, blank=False, default="")
    state = models.CharField(max_length=50, blank=False, default="")
    area = models.CharField(max_length=50, blank=False, default="")
    address = models.CharField(max_length=50, blank=False, default="")
    pincode = models.CharField(max_length=50, blank=False, default="")
    password = models.CharField(max_length=50, blank=False, default="")
