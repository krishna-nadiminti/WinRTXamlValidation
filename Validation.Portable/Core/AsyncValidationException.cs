﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AsyncValidationException.cs" company="-" year="2013">
//   Matthias Jauernig (matthias.jauernig@live.de)
//   Markus Demmler (markus.demmler@sdx-ag.de)
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace WinRTXAMLValidation.Library.Core
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using WinRTXAMLValidation.Library.Attributes;

    /// <summary>
    /// The async validation exception class, which extends the <see cref="ValidationException"/> type 
    /// for the <see cref="AsyncValidationAttribute"/>.
    /// </summary>
    public class AsyncValidationException : ValidationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncValidationException"/> class 
        /// using an error message generated by the system.
        /// </summary>
        public AsyncValidationException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncValidationException"/> class using a specified error message.
        /// </summary>
        /// <param name="message"> A specified message that states the error. </param>
        public AsyncValidationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncValidationException"/> class 
        /// using a specified error message and a collection of inner exception instances.
        /// </summary>
        /// <param name="message"> The error message. </param>
        /// <param name="innerException"> The collection of validation exceptions. </param>
        public AsyncValidationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncValidationException"/> class 
        /// using a specified error message, a validation attribute, and the value of the current exception.
        /// </summary>
        /// <param name="errorMessage"> The message that states the error. </param>
        /// <param name="validatingAttribute"> The attribute that caused the current exception. </param>
        /// <param name="value"> The value of the object that caused the attribute to trigger validation error. </param>
        public AsyncValidationException(string errorMessage, ValidationAttribute validatingAttribute, object value)
            : base(errorMessage, validatingAttribute, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncValidationException"/> class 
        /// by using a validation result, a validation attribute, and the value of the current exception.
        /// </summary>
        /// <param name="validationResult"> The list of validation results. </param>
        /// <param name="validatingAttribute"> The attribute that caused the current exception. </param>
        /// <param name="value"> The value of the object that caused the attribute to trigger the validation error. </param>
        public AsyncValidationException(ValidationResult validationResult, ValidationAttribute validatingAttribute, object value)
            : base(validationResult, validatingAttribute, value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncValidationException"/> class 
        /// using a specified error message, a validation attribute, and the value of the current exception.
        /// </summary>
        /// <param name="errorMessage"> The message that states the error. </param>
        /// <param name="validatingAttribute"> The attribute that caused the current exception. </param>
        /// <param name="value"> The value of the object that caused the attribute to trigger validation error. </param>
        public AsyncValidationException(string errorMessage, AsyncValidationAttribute validatingAttribute, object value)
            : base(errorMessage, null, value)
        {
            this.ValidatingAttribute = validatingAttribute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncValidationException"/> class 
        /// by using a validation result, a validation attribute, and the value of the current exception.
        /// </summary>
        /// <param name="validationResult"> The list of validation results. </param>
        /// <param name="validatingAttribute"> The attribute that caused the current exception. </param>
        /// <param name="value"> The value of the object that caused the attribute to trigger the validation error. </param>
        public AsyncValidationException(ValidationResult validationResult, AsyncValidationAttribute validatingAttribute, object value)
            : base(validationResult, null, value)
        {
            this.ValidatingAttribute = validatingAttribute;
        }

        /// <summary>
        /// Gets or sets the validating attribute.
        /// </summary>
        public AsyncValidationAttribute ValidatingAttribute { get; set; }
    }
}